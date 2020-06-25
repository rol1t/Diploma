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
    public partial class TestStatForm : MaterialForm, ITestStatView
    {
        private readonly TestStatPresenter _presenter;

        public TestStatForm(int testId)
        {
            InitializeComponent();
            _presenter = new TestStatPresenter(this);
            _presenter.Load(testId);
        }

        public string TestName { get => this.Text; set => this.Text = value; }
        public List<Result> Results 
        { 
            get => grResults.DataSource as List<Result>; 
            set 
            {
                grResults.DataSource = new List<ResultView>();
                grResults.Columns["UserName"].HeaderText = "Имя";
                grResults.Columns["Score"].HeaderText = "Количество баллов";
                grResults.Columns["Procent"].HeaderText = "Процент прохождения";
                grResults.DataSource = value.Select(r => 
                    new ResultView 
                    { 
                        UserName = r.User.UserName, 
                        Score = r.Score, 
                        Procent = Math.Round(r.Score / TestScore, 2) * 100
                    }).ToList();
                grResults.ReadOnly = true;
                grResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        public string Count { get => txtCount.Text; set => txtCount.Text = value; }
        public string AvgProcent { get => txtAvgProcent.Text; set => txtAvgProcent.Text = value; }
        public decimal TestScore { get; set; }

        public List<ResultView> ResultViews => grResults.DataSource as List<ResultView>;

        public class ResultView
        {
            public string UserName { get; set; }
            public decimal Score { get; set; }
            public decimal Procent { get; set; }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            _presenter.Print();
        }
    }
}
