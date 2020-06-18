using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Views
{
    public interface IResultView
    {
        public int ResultId { get; set; }
        public int TestId { get; set; }
        public int UserId { get; set; }
        public int Points { get; set; }
        public List<Result> Results { get; set; }
        public string UserRank { get; set; }
    }
}
