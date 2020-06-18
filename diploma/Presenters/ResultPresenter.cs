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
    public class ResultPresenter : GenericPresenter<IResultView>
    {
        public ResultPresenter(IResultView view) : base(view)
        {
        }

        public void LoadResult(int resultId)
        {
            using var context = new Context();
            var result = context.Results
                .Include(r => r.Test)
                .Include(r => r.User)
                .FirstOrDefault(r => r.Id == resultId);
            View.Results = context.Results
                .Include(r => r.Test)
                .Include(r => r.User)
                .Where(r => r.TestId == result.TestId).ToList();
            View.ResultId = result.Id;
            View.UserId = result.UserId;
            View.Points = result.Score;
            View.TestId = result.TestId;
            var procent = (decimal)result.Score / (decimal)context.Tests
                .Include(t => t.Questions)
                .FirstOrDefault(t => t.Id == result.TestId)
                .Questions.Sum(q => q.Points);
            View.UserRank = $"Ваш результат {procent * 100}%.";
        }
    }
}
