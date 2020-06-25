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
using diploma.Models;
using diploma.Services;
using static diploma.TestStatForm;

namespace diploma.UI
{
    public partial class ProfilePage : UserControl, IProfileView
    {
        private readonly ProfilePresenter _presenter;

        public ProfilePage()
        {
            InitializeComponent();
            UserId = GetUserDataService.CurrentUser.Id;
            _presenter = new ProfilePresenter(this);
        }

        public ProfilePage(int userId)
        {
            InitializeComponent();
            UserId = userId;
            btLogout.Visible = false;
            _presenter = new ProfilePresenter(this);
        }

        public string Login { set => txtLogin.Text = $"Логин: {value}"; }
        public string UserName { set => txtName.Text = $"Имя: {value}"; }
        public string Role {  set => txtRole.Text = $"Роль: {value}"; }
        public string ComplTest { set => txtComplTest.Text = $"Пройдено тестов: {value}"; }
        public string AvgTest { set => txtAvgProcent.Text = $"Средний процент прохождения: {value}"; }
        public int UserId { get; set; }
        public List<Result> Results 
        { 
            get => grResults.DataSource as List<Result>;
            set 
            {
                grResults.DataSource = value
                    .Select(r => new { r.Test.Name, r.Score })
                    .ToList();
                var columns = grResults.Columns;
                foreach (DataGridViewColumn item in columns)
                {
                    item.Visible = false;
                }
                columns["Name"].Visible = true;
                columns["Score"].Visible = true; 
                columns["Name"].HeaderText = "Название теста";
                columns["Score"].HeaderText = "Балл";
                grResults.ReadOnly = true;
                grResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            _presenter.Logout();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePage_Enter(object sender, EventArgs e)
        {
            _presenter.Load();
        }
    }
}
