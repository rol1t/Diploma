using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static diploma.TestStatForm;

namespace diploma.Views
{
    public interface ITestStatView
    {
        public decimal TestScore { get; set; }
        public string TestName { get; set; }
        public List<Result> Results { set; }
        public List<ResultView> ResultViews { get; }
        public string Count { get; set; }
        public string AvgProcent { get; set; }
    }
}
