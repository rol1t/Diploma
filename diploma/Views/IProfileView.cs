using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Views
{
    public interface IProfileView
    {
        public int UserId { get; set; }
        string Login { set; }
        string UserName { set; }
        public string Role { set; }
        public string ComplTest { set; }
        public string AvgTest { set; }
        public List<Result> Results { get; set; }
    }
}
