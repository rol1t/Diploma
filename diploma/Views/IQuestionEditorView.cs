using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diploma.Models;

namespace diploma.Views
{
    public interface IQuestionEditorView
    {
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public string Description { get; set; }
        public bool IsMulti { get; set; }
        public List<Variant> Variants { get; set; }
        public Dictionary<string, bool> VariantsListItem { get; }
    }
}
