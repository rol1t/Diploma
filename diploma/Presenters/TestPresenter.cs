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

namespace diploma.Presenters
{
    public class TestPresenter : GenericPresenter<ITestView>
    {
        public TestPresenter(ITestView view) : base(view)
        {
            _timer = new Timer();
        }

        private readonly Timer _timer;

        public void LoadTest(int testId)
        {
            using var context = new Context();
            var loadedTest = FetchTest(testId);
            View.TestId = testId;
            foreach (var item in loadedTest.Questions.SelectMany(q => q.Variants))
            {
                item.IsTrue = false;
            }
            View.Time = new TimeSpan(0, (int)loadedTest.Time, 0);
            View.CurrentTime = new TimeSpan(0);
            _timer.Interval = 1000;
            _timer.Tick += (o, s) =>
            {
                View.CurrentTime = View.CurrentTime + new TimeSpan(0, 0, 1);
                if (View.CurrentTime >= View.Time)
                {
                    EndTest();
                }
            };
            View.TestName = loadedTest.Name;
            View.Questions = loadedTest.Questions.OrderBy(q => q.Id).ToList(); ;
            View.CurrentQuestion = loadedTest.Questions.FirstOrDefault();
            View.Variants = View.CurrentQuestion?.Variants?.ToList();
            View.QuestionNumber = 1;
            View.QuestionDescription = View.CurrentQuestion.Description;
            UpdateQuestion();
            _timer.Start();
        }

        public void EndTest()
        {
            using var context = new Context();
            _timer.Enabled = false;
            var test = FetchTest(View.TestId);
            var result = GenerateResult(test);
            var previousResult = context.Results.Where(r => r.UserId == result.UserId && result.TestId == r.TestId && r.Score <= result.Score);
            if (previousResult != null)
            {
                context.Results.RemoveRange(previousResult);
            }
            context.Results.Add(result);
            context.SaveChanges();
            var form = new ResultForm(result);
            form.ShowDialog();
            View.EndTest();
        }

        public void NextQuestion()
        {
            var question = View.Questions.FirstOrDefault(q => q.Id > View.CurrentQuestion.Id);
            if (question == null)
            {
                View.EndButtonVisible = true;
                return;
            }
            View.CurrentQuestion = question;
            UpdateQuestion();
        }

        public void PreviousQuestion()
        {
            var question = View.Questions.FirstOrDefault(q => q.Id < View.CurrentQuestion.Id);
            if (question == null)
            {
                return;
            }
            View.CurrentQuestion = question;
            UpdateQuestion();
        }

        public void ChangeVariant(string variantName, bool value)
        {
            if (!View.CurrentQuestion.Variants.Any(v => v.Title == variantName))
            {
                return;
            }
            var variant = View.CurrentQuestion.Variants.FirstOrDefault(v => v.Title == variantName);
            variant.IsTrue = value;
        }

        private void ChangeNumber()
        {
            var num = View.Questions.ToList().IndexOf(View.CurrentQuestion);
            View.QuestionNumber = num;
        }

        private void UpdateQuestion()
        {
            if (View.CurrentQuestion == null)
            {
                MessageBox.Show($"Переменная пуста! {nameof(View.CurrentQuestion)}");
                return;
            }
            ChangeNumber();
            View.VariantListView.Items.Clear();
            View.QuestionDescription = View.CurrentQuestion.Description;
            foreach (var item in View.Variants ?? new List<Variant>())
            {
                View.VariantListView.Items.Add(item.Title ?? string.Empty, item.IsTrue);
            }
        }


        private Test FetchTest(int testId)
        {
            using var context = new Context();
            return context.Tests
                .Include(t => t.Results)
                .Include(t => t.User)
                .Include(t => t.Questions)
                .ThenInclude(q => q.Variants)
                .Include(t => t.TestThemes)
                .ThenInclude(tt => tt.Theme)
                .FirstOrDefault(t => t.Id == testId);
        }

        private Result GenerateResult(Test test)
        {
            var points = 0;
            foreach (var item in test.Questions)
            {
                var comlQuestion = View.Questions.First(q => q.Id == item.Id);
                var isCorrect = true;
                foreach (var variant in item.Variants)
                {
                    var complVariant = comlQuestion.Variants.First(v => v.Id == variant.Id);
                    if (complVariant.IsTrue != variant.IsTrue)
                    {
                        isCorrect = false;
                        break;
                    }
                }
                if (isCorrect)
                {
                    points += item.Points;
                }
            }
            return new Result
            {
                Score = points,
                TestId = test.Id,
                UserId = GetUserDataService.CurrentUser.Id
            };
        }

        //private void HideNextShowEnd()
        //{
        //    View.EndButtonVisible = true;
        //    View.NextQuestionButtonEnable = false;
        //    View.PreviousQuestionButtonEnable = true;
        //}

        //private void HidePrevious()
        //{
        //    View.PreviousQuestionButtonEnable = false;
        //    View.NextQuestionButtonEnable = true;
        //}
    }
}
