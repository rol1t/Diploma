using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public IEnumerable<Test> Tests { get; set; }
        public IEnumerable<Theme> Themes { get; set; }
    }
}
