using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Views
{
    public interface IAddTestView
    {
        public string TestName { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
        public string Message { get; set; }
    }
}
