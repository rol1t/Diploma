using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Variant> Variants { get; set; }
        public IEnumerable<Variant> TrueVariants { get; set; }
        public int AccurateRate { get; set; }
        public int Attempts { get; set; }
    }
}
