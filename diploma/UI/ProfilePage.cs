using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diploma.Views;
using diploma.Presenters;

namespace diploma.UI
{
    public partial class ProfilePage : UserControl, IProfileView
    {
        private readonly ProfilePresenter _presenter;

        public ProfilePage()
        {
            InitializeComponent();
            _presenter = new ProfilePresenter(this);
        }

        //public string Login { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void btLogout_Click(object sender, EventArgs e)
        {
            _presenter.Logout();
        }
    }
}
