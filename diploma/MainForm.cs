using diploma.Models;
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

namespace diploma
{
    public partial class MainForm : MaterialForm, IMainView
    {
        public User User { get; }

        MainForm IMainView.MainForm => this;

        private readonly IServiceProvider _sp;

        public MainForm(User result, IServiceProvider sp)
        {
            InitializeComponent();
            _sp = sp;
            User = result;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var presenter = new MainPresenter(this);
            presenter.SetRoleVisibleSettings();
        }
    }
}
