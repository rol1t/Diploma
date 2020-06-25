using diploma.UI;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma
{
    public partial class UserForm : MaterialForm
    {
        public UserForm(int userId)
        {
            InitializeComponent();
            var control = new ProfilePage(userId);
            control.Dock = DockStyle.Fill;
            control.BackColor = Color.White;
            this.Controls.Add(control);
        }
    }
}
