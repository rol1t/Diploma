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

        RichTextBoxEx.RichTextBoxEx Content { get; }
    }
}
