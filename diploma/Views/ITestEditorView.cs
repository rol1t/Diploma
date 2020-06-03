using diploma.Models;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma.Views
{
    public interface ITestEditorView
    {
        public int TestId { get; set; }
        public string FormTitle { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public IEnumerable<Theme> Themes { get; set; }
        public IEnumerable<Theme> AllThemes { get; set; }
        public ComboBox AllThemesCb { get; }
        public MetroGrid QuestionGr { get; }
        public MetroGrid ThemeGr { get; }
    }
}
