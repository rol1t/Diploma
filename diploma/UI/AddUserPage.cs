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
using diploma.Models;

namespace diploma.UI
{
    public partial class AddUserPage : UserControl, IAddUserView
    {
        private readonly AddUserPresenter _presenter;

        public AddUserPage()
        {
            InitializeComponent();
            _presenter = new AddUserPresenter(this);
        }

        public string Login { get => txtLogin.Text; set => txtLogin.Text = value; }
        public string UserName { get => txtUserName.Text; set => txtUserName.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public string PasswordConfirmation { get => txtPasswordConfirm.Text; set => txtPasswordConfirm.Text = value; }
        public bool IsTeacher { get => swIsTeacher.Checked; set => swIsTeacher.Checked = value; }
        public string Message { get => txtError.Text; set => txtError.Text = value; }
        public List<User> Users 
        { 
            get => grUsers.DataSource as List<User>;
            set 
            {
                grUsers.DataSource = value;
                var columns = grUsers.Columns;
                foreach (DataGridViewColumn item in columns)
                {
                    item.Visible = false;
                }
                columns["UserName"].Visible = true;
                columns["UserName"].HeaderText = "Имя";
                grUsers.ReadOnly = true;
                grUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        public User SelectedUser { get => grUsers.SelectedRows[0].DataBoundItem as User; }

        private async void btAddUser_Click(object sender, EventArgs e)
        {
            await _presenter.AddUser();
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            _presenter.ClearValue();
        }

        private void AddUserPage_Enter(object sender, EventArgs e)
        {
            _presenter.LoadUsers();
        }

        private void grUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _presenter.ShowUser();
        }
    }
}
