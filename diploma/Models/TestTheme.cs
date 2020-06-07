using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Models
{
    public class TestTheme
    {
        public int TestId { get; set; }
        public Test Test { get; set; }
        public int ThemeId { get; set; }
        public Theme Theme { get; set; }
    }
}
