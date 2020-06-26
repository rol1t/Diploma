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
            _presenter.UpdateTests().ConfigureAwait(true);
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
                c["Name"].HeaderText = "Название теста";
                metroGrid1.ReadOnly = true;
                metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public bool EditButtonVisible { get => materialButton1.Visible; set => materialButton1.Visible = false; }

        public Test SelectedTest => metroGrid1.SelectedRows
            .Cast<DataGridViewRow>()
            .FirstOrDefault()
            .DataBoundItem as Test;

        public List<Subject> Subjects 
        { 
            get => cbSubjects.DataSource as List<Subject>;
            set 
            {
                cbSubjects.DataSource = value;
                cbSubjects.ValueMember = "Id";
                cbSubjects.DisplayMember = "Alias";
                cbSubjects.SelectedValue = -1;
            }
        }

        public Subject SelectedSubject => cbSubjects.SelectedItem as Subject;

        public List<Theme> Themes
        {
            get => materialComboBox1.DataSource as List<Theme>;
            set
            {
                materialComboBox1.DataSource = value;
                materialComboBox1.ValueMember = "Id";
                materialComboBox1.DisplayMember = "Name";
                materialComboBox1.SelectedValue = -1;
            }
        }
        public Theme SelectedTheme { get => materialComboBox1.SelectedItem as Theme; }

        private void TestPageCustomControl_Load(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            _presenter.EditTest();
            _presenter.UpdateTests();
        }

        private void metroGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _presenter.OpenTest();
        }

        private async void TestPageCustomControl_Enter(object sender, EventArgs e)
        {
            await _presenter.UpdateTests();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            _presenter.Print();
        }

        private void btTestStat_Click(object sender, EventArgs e)
        {
            _presenter.OpenTestStat();
        }

        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.Filter();
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.Filter();
        }
    }
}
