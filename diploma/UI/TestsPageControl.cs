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
    public partial class TestsPageControl : UserControl, ITestsPageView
    {
        private readonly TestsPresenter _presenter;
        public TestsPageControl()
        {
            InitializeComponent();
            _presenter = new TestsPresenter(this);
        }

        public List<Test> Tests 
        { 
            get => grTests.DataSource as List<Test>; 
            set 
            {
                grTests.DataSource = value;
                var c = grTests.Columns;
                foreach (DataGridViewColumn item in c)
                {
                    item.Visible = false;
                }
                c["Name"].Visible = true;
                c["Name"].HeaderText = "Название теста";
                grTests.ReadOnly = true;
                grTests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            } 
        }

        public bool EditButtonVisible { get => btEditTheme.Visible; set => btEditTheme.Visible = value; }
        public Test SelectedTest 
        { 
            get => grTests.SelectedRows
                ?.Cast<DataGridViewRow>()
                ?.FirstOrDefault()
                ?.DataBoundItem as Test; 
        }

        private void grTests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _presenter.OpenTest();
        }
    }
}
