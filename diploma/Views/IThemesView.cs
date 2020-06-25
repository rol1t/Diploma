using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma.Views
{
    public interface IThemesView
    {
        List<Theme> Themes { get; set; }

        DataGridView Grid { get; }

        List<Subject> Subjects { get; set; }

        Subject SelectedSubject { get; }
    }
}
