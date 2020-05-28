using diploma.Presenters;
using diploma.Views;
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
using Microsoft.Extensions.DependencyInjection;
using diploma.Models;

namespace diploma
{
    public partial class LoginForm : MaterialForm, ILoginView
    {
        public IServiceProvider ServiceProvider { get; }

        private readonly LoginPresenter _presenter;

        public LoginForm(IServiceProvider sp)
        {
            InitializeComponent();
            ServiceProvider = sp;
            _presenter = new LoginPresenter(this);
        }

        public string Login 
        { 
            get => txtLogin.Text; 
            set => txtLogin.Text = value; 
        }

        public string Password 
        { 
            get => txtPassword.Text; 
            set => txtPassword.Text = value; 
        }

        public bool RememberMe 
        { 
            get => swRemberMe.Checked; 
            set => swRemberMe.Checked = value; 
        }

        public string ErrorMessage 
        { 
            get => lbError.Text; 
            set => lbError.Text = value; 
        }

        LoginForm ILoginView.LoginForm { get => this; }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            await _presenter.Login();
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            await _presenter.AutoLogin();
        }
    }
}
