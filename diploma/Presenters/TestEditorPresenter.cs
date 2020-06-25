using diploma.Models;
using diploma.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma.Presenters
{
    public class TestEditorPresenter : GenericPresenter<ITestEditorView>
    {
        public TestEditorPresenter(ITestEditorView view) : base(view)
        {
        }

        public void InitForm(Test test)
        {
            View.TestId = test.Id;
            using var context = new Context();
            var subjects = context.Subjects.ToList();
            var nullSubject = new Subject { Id = -1, Alias = "-" };
            subjects.Add(nullSubject);
            View.Subjects = context.Subjects.ToList();
            View.SelectedSubject = View.Subjects.FirstOrDefault(s => s.Id == test.SubjectId) ?? nullSubject;
            View.FormTitle = test.Name;
            View.ThemeGr.DataSource = new List<Theme>();
            HideAllColumns(View.ThemeGr);
            View.ThemeGr.Columns["Name"].Visible = true;
            View.ThemeGr.Columns["Name"].HeaderText = "Название темы";
            View.ThemeGr.ReadOnly = true;
            View.ThemeGr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            View.QuestionGr.DataSource = new List<Question>();
            HideAllColumns(View.QuestionGr);
            View.QuestionGr.Columns["Name"].HeaderText = "Название вопроса";
            View.QuestionGr.Columns["Name"].Visible = true;
            View.QuestionGr.ReadOnly = true;
            View.QuestionGr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            UpdateQuestions();
            UpdateAllThemes();
        }

        public void UpdateAllThemes()
        {
            using var context = new Context();
            View.AllThemes = context.Themes;
            View.Themes = context.Tests
                .Include(t => t.TestThemes)
                .ThenInclude(t => t.Theme)
                .FirstOrDefault(t => t.Id == View.TestId)
                .TestThemes.Select(tt => tt.Theme);
        }

        public void AddQuestion()
        {
            using var context = new Context();
            var test = context.Tests
                .Include(t => t.Questions)
                .FirstOrDefault(t => t.Id == View.TestId);
            test.Questions.Add(new Question { Name = "Новый вопрос" });
            context.SaveChanges();
            View.Questions = test.Questions;
        }

        public void DeleteQuestion()
        {
            using var context = new Context();
            var test = context.Tests
                .Include(t => t.Questions)
                .FirstOrDefault(t => t.Id == View.TestId);

            var rowIndex = View.QuestionGr.SelectedCells.Cast<DataGridViewCell>()
                .FirstOrDefault()?.RowIndex;
            if (rowIndex == null)
            {
                return;
            }
            var questionId = (int?) View.QuestionGr.Rows[rowIndex.Value].Cells["Id"].Value;
            if (questionId == null)
            {
                return;
            }
            var question = test.Questions.FirstOrDefault(q => q.Id == questionId);
            test.Questions.Remove(question);
            context.SaveChanges();
            View.Questions = test.Questions;
        }

        internal void ChangeSubject()
        {
            using var context = new Context();
            var test = context.Tests.FirstOrDefault(s => View.TestId == s.Id);
            if (View.SelectedSubject != null)
            {
                test.Subject = View.SelectedSubject;
                context.SaveChanges();
            }
        }

        public void EditQuestion()
        {
            using var context = new Context();
            var test = context.Tests
                .Include(t => t.Questions)
                .FirstOrDefault(t => t.Id == View.TestId);

            var rowIndex = View.QuestionGr.SelectedCells.Cast<DataGridViewCell>()
                .FirstOrDefault()?.RowIndex;
            if (rowIndex == null)
            {
                return;
            }
            var questionId = (int?)View.QuestionGr.Rows[rowIndex.Value].Cells["Id"].Value;
            if (questionId == null)
            {   
                return;
            }
            var form = new QuestionEditor(questionId.Value);
            form.ShowDialog();
            UpdateQuestions();
        }

        public void LinkTheme(int themeId)
        {
            using var contex = new Context();
            var test = contex.Tests
                .Include(t => t.TestThemes)
                .ThenInclude(tt => tt.Theme)
                .FirstOrDefault(t => t.Id == View.TestId);
            var theme = new TestTheme
            {
                Theme = contex.Themes.FirstOrDefault(t => t.Id == themeId),
                Test = test
            };
            test.TestThemes.Add(theme);
            contex.SaveChanges();
            View.Themes = test.TestThemes
                .Select(t => t.Theme)
                .Select(t => new Theme { Id = t.Id, Name = t.Name });
            UpdateAllThemes();
        }

        public void DeleteTheme()
        {
            using var contex = new Context();
            var rowIndex = View.ThemeGr.SelectedCells
                .Cast<DataGridViewCell>()
                .FirstOrDefault()?.RowIndex;
            if (rowIndex == null)
            {
                return;
            }
            var themeId = (int?) View.ThemeGr.Rows[rowIndex.Value].Cells["Id"]?.Value;
            if (themeId == null)
            {
                return;
            }
            var test = contex.Tests
                .Include(t => t.TestThemes)
                .ThenInclude(tt => tt.Theme)
                .FirstOrDefault(t => t.Id == View.TestId);
            var theme = contex.TestThemes.FirstOrDefault(t => t.ThemeId == themeId);
            test.TestThemes.Remove(theme);
            contex.SaveChanges();
            View.Themes = test.TestThemes
                .Select(tt => tt.Theme)
                .Select(t => new Theme { Id = t.Id, Name = t.Name });
            UpdateAllThemes();
        }

        private void HideAllColumns(DataGridView grid)
        {
            foreach (var item in grid.Columns.Cast<DataGridViewColumn>())
            {
                item.Visible = false;
            }
        }

        private void UpdateQuestions()
        {
            using var context = new Context();
            View.QuestionGr.DataSource = context.Tests
                            .Include(t => t.Questions)
                            .FirstOrDefault(t => t.Id == View.TestId)
                            .Questions;
        }

    }
}
