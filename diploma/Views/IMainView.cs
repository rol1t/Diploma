using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma.Views
{
    public interface IMainView
    {
        User User { get; }
        Form MainForm { get; }
    }
}
