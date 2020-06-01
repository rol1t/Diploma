using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Views
{
    public interface IThemeReaderView
    {
        Theme Theme { get; set; }
        string HeaderText { get; set; }
        string Content { get; set; }
    }
}
