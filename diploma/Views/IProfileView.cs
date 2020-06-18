using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Views
{
    public interface IProfileView
    {
        string Login { set; }
        string UserName { set; }
        public string Role { set; }
        public string ComplTest { set; }
        public string AvgTest { set; }
    }
}
