using diploma.Models;
using diploma.Services;
using diploma.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace diploma.Presenters
{
    public class TestsPresenter : GenericPresenter<ITestsPageView>
    {
        public TestsPresenter(ITestsPageView view) : base(view)
        {
            Init();
        }

        public void Init()
        {
            if (GetUserDataService.CurrentUser.RoleId != 1)
            {
                View.EditButtonVisible = false;
            }
        }

        public void EditTest()
        {
            var form = new TestEditor(View.SelectedTest);
            form.ShowDialog();
        }

        public async Task UpdateTests()
        {
            using (var context = new Context())
            {
                View.Tests = await context.Tests.ToListAsync();
            }
            
        }

        public void OpenTest()
        {
            if (View.SelectedTest == null)
            {
                return;
            }
            using var context = new Context();
            var loadedTest = context.Tests
                .Include(t => t.TestThemes)
                .ThenInclude(tt => tt.Theme)
                .Include(t => t.Questions)
                .FirstOrDefault(t => t.Id == View.SelectedTest.Id);
            var form = new TestInfoForm(View.SelectedTest);
            form.ShowDialog();
        }

        public void Print()
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.FileName = $"{View.SelectedTest.Name}.docx";
            saveDialog.ShowDialog();
            using var document = DocX.Create(saveDialog.FileName);
            var p = document.InsertParagraph();
            p.AppendLine(View.SelectedTest.Name).FontSize(20);
            using var context = new Context();
            var questions = context.Tests
                .Include(t => t.Questions)
                .ThenInclude(t => t.Variants)
                .FirstOrDefault(t => t.Id == View.SelectedTest.Id).Questions;
            foreach (var item in questions)
            {
                var bulletedList = document.AddList($"{questions.IndexOf(item) + 1}. {item.Description}", 0, ListItemType.Bulleted);
                foreach (var variant in item.Variants)
                {
                    document.AddListItem(bulletedList, variant.Title, 1);
                }
                document.InsertList(bulletedList, new Font("Times New Roman") ,14);
            }
            document.Save();
        }
    }
}
