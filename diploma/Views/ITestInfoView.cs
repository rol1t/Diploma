using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Views
{
    public interface ITestInfoView
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public string Description { get; set; }
        public int Time { set; }
        public IEnumerable<Question> Questions { get; set; }
    }
}
