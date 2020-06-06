using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diploma.Models;
using MaterialSkin.Controls;

namespace diploma.Views
{
    public interface IQuestionEditorView
    {
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public string Description { get; set; }
        public bool IsMulti { get; set; }
        public string VariantName { get; set; }
        public List<Variant> Variants { get; set; }
        public CheckedListBox VariantList { get; }
    }
}
