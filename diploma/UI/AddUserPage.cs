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
using MaterialSkin.Controls;

namespace diploma.UI
{
    public partial class AddUserPage : UserControl, IAddUserView
    {
        private readonly AddUserPresenter _presenter;

        public AddUserPage()
        {
            InitializeComponent();
            MaterialForm
            _presenter = new AddUserPresenter(this);
        }

        public string Login { get => txtLogin.Text; set => txtLogin.Text = value; }
        public string UserName { get => txtUserName.Text; set => txtUserName.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string PasswordConfirmation { get => txtPasswordConfirm.Text; set => txtPasswordConfirm.Text = value; }
        public bool IsTeacher { get => swIsTeacher.Checked; set => swIsTeacher.Checked = value; }
        public string Message { get => txtError.Text; set => txtError.Text = value; }

        private async void btAddUser_Click(object sender, EventArgs e)
        {
            await _presenter.AddUser();
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            _presenter.ClearValue();
        }
    }
}
