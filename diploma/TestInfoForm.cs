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
    public partial class TestInfoForm : MaterialForm, ITestInfoView
    {
        private readonly TestInfoPresenter _presenter;

        public TestInfoForm(Test selectedTest)
        {
            InitializeComponent();
            _presenter = new TestInfoPresenter(this);
            _presenter.LoadTest(selectedTest);
        }

        public int TestId { get; set; }
        public string TestName { get => this.Text; set => this.Text = value; }
        public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
        public IEnumerable<Question> Questions 
        { 
            get => grQuestions.DataSource as IEnumerable<Question>;
            set 
            {
                grQuestions.DataSource = value;
                var c = grQuestions.Columns;
                foreach (var item in c.Cast<DataGridViewColumn>())
                {
                    item.Visible = false;
                }
                c["Name"].Visible = true;
                c["Name"].HeaderText = "Вопросы";
                grQuestions.ReadOnly = true;
                grQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            } 
        }
        public int Time { set => txtTime.Text = $"Времени на тест: {value} мин"; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btStartTest_Click(object sender, EventArgs e)
        {
            var form = new TestForm(TestId);
            form.ShowDialog();
        }
    }
}
