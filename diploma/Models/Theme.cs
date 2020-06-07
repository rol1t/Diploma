using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Models
{
    [Serializable]
    public class Theme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Rtf content file
        /// </summary>
        public string Content { get; set; }
        public int? SubjectId { get; set; }
        public Subject Subject { get; set; }
        public IEnumerable<TestTheme> TestThemes { get; set; }
    }
}
