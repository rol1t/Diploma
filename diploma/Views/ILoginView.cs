using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma.Views
{
    public interface ILoginView
    {
        string Login { get; set; }

        string Password { get; set; }

        bool RememberMe { get; set; }

        string ErrorMessage { get; set; }

        Form LoginForm { get; }
    }
}
