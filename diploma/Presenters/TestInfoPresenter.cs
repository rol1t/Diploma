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
    public class TestInfoPresenter : GenericPresenter<ITestInfoView>
    {
        public TestInfoPresenter(ITestInfoView view) : base(view)
        {
        }

        public void LoadTest(Test test1)
        {
            using var context = new Context();
            var test = context.Tests
                .Include(t => t.Questions)
                .Include(t => t.Subject)
                .Include(t => t.TestThemes)
                .FirstOrDefault(t => t.Id == test1.Id);
            View.TestId = test.Id;
            View.Description = test.Description;
            View.TestName = test.Name;
            View.Questions = test.Questions;
            View.Time = (int)test.Time;
        }
    }
}
