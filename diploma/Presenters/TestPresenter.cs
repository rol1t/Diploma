using diploma.Models;
using diploma.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class TestPresenter : GenericPresenter<ITestView>
    {
        public TestPresenter(ITestView view) : base(view)
        {
        }

        public void LoadTest(int testId)
        {
            using var context = new Context();
            var loadedTest = context.Tests
                .Include(t => t.Results)
                .Include(t => t.User)
                .Include(t => t.Questions)
                .ThenInclude(q => q.Variants)
                .Include(t => t.TestThemes)
                .ThenInclude(tt => tt.Theme)
                .FirstOrDefault(t => t.Id == testId);
            View.Time = new TimeSpan(0, (int)loadedTest.Time, 0);
            View.TestName = loadedTest.Name;
            View.Questions = loadedTest.Questions.OrderBy(q => q.Id).ToList(); ;
            View.CurrentQuestion = loadedTest.Questions.FirstOrDefault();
            View.EndButtonVisible = false;
            View.PreviousQuestionButtonEnable = false;
            View.NextQuestionButtonEnable = true;
            View.Variants = View.CurrentQuestion?.Variants?.ToList();
            View.QuestionNumber = 1;
            View.QuestionDescription = loadedTest.Description;
            UpdateVariantList();
        }

        public void NextQuestion()
        {
            var question = View.Questions.FirstOrDefault(q => q.Id > View.CurrentQuestion.Id);
            if (question == null)
            {
                HideNextShowEnd();
                return;
            }
            if (View.QuestionNumber == View.Questions.Count() - 1)
            {
                HideNextShowEnd();
                View.QuestionNumber++;
                return;
            }
            View.QuestionNumber++;
            View.EndButtonVisible = false;
            View.NextQuestionButtonEnable = true;
            View.CurrentQuestion = question;
            UpdateVariantList();
        }

        private void HideNextShowEnd()
        {
            View.EndButtonVisible = true;
            View.NextQuestionButtonEnable = false;
            View.PreviousQuestionButtonEnable = true;
        }

        private void HidePrevious()
        {
            View.PreviousQuestionButtonEnable = false;
            View.NextQuestionButtonEnable = true;
        }

        public void PreviousQuestion()
        {
            var question = View.Questions.FirstOrDefault(q => q.Id < View.CurrentQuestion.Id);
            if (question == null || View.QuestionNumber == 1)
            {
                HidePrevious();
                return;
            }
            View.PreviousQuestionButtonEnable = true;
            View.EndButtonVisible = false;
            View.NextQuestionButtonEnable = true;
            View.CurrentQuestion = question;
            View.QuestionNumber--;
            UpdateVariantList();
        }

        private void UpdateVariantList()
        {
            View.VariantListView.Items.Clear();
            foreach (var item in View.Variants ?? new List<Variant>())
            {
                View.VariantListView.Items.Add(item.Title ?? string.Empty, false);
            }
        }
    }
}
