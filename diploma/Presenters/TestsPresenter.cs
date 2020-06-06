using diploma.Models;
using diploma.Services;
using diploma.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class TestsPresenter : GenericPresenter<ITestsPageView>
    {
        public TestsPresenter(ITestsPageView view) : base(view)
        {
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
            using var context = new Context();
            View.Tests = await context.Tests.ToListAsync();
        }

        public void OpenTest()
        {
            if (View.SelectedTest == null)
            {
                return;
            }
            using var context = new Context();
            var loadedTest = context.Tests
                .Include(t => t.Themes)
                .Include(t => t.Questions)
                .FirstOrDefault(t => t.Id == View.SelectedTest.Id);
            var form = new TestInfoForm(View.SelectedTest);
            form.ShowDialog();
        }
    }
}
