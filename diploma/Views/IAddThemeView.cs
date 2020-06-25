using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma.Views
{
    public interface IAddThemeView
    {
        string ThemeName { get; set; }

        string Message { get; set; }

        public List<Subject> Subjects { get; set; }

        public Subject SelectedSubject { get; }

        RichTextBoxEx.RichTextBoxEx Content { get; }
    }
}
