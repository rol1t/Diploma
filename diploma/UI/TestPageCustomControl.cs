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
using diploma.Models;
using diploma.Presenters;

namespace diploma.UI
{
    public partial class TestPageCustomControl : UserControl, ITestsPageView
    {
        private readonly TestsPresenter _presenter;

        public TestPageCustomControl()
        {
            InitializeComponent();
            _presenter = new TestsPresenter(this);
            _presenter.UpdateTests();
        }

        public List<Test> Tests 
        { 
            get => metroGrid1.DataSource as List<Test>;
            set
            {
                metroGrid1.DataSource = value;
                var c = metroGrid1.Columns;
                foreach (DataGridViewColumn item in c)
                {
                    item.Visible = false;
                }
                c["Name"].Visible = true;
                c["Name"].HeaderText = "Название тесты";
                metroGrid1.ReadOnly = true;
                metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public bool EditButtonVisible { get => materialButton1.Visible; set => materialButton1.Visible = false; }

        public Test SelectedTest => metroGrid1.SelectedRows
            .Cast<DataGridViewRow>()
            .FirstOrDefault()
            .DataBoundItem as Test;

        private void TestPageCustomControl_Load(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            _presenter.EditTest();
        }

        private void metroGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _presenter.OpenTest();
        }
    }
}
