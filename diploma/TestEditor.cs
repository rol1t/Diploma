using diploma.Models;
using diploma.Presenters;
using diploma.Views;
using MaterialSkin.Controls;
using MetroFramework.Controls;
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
    public partial class TestEditor : MaterialForm, ITestEditorView
    {
        private readonly TestEditorPresenter _presenter;

        public TestEditor(Test test)
        {
            InitializeComponent();
            _presenter = new TestEditorPresenter(this);
            _presenter.InitForm(test);
        }

        public IEnumerable<Question> Questions 
        { 
            get => grQuestions.DataSource as IEnumerable<Question>; 
            set 
            { 
                grQuestions.DataSource = value.ToList();
            } 
        }

        public IEnumerable<Theme> Themes 
        {
            get
            {
                return grThemes.DataSource as IEnumerable<Theme>;
            }
            set
            {
                grThemes.DataSource = value.ToList();
            }
        }

        public IEnumerable<Theme> AllThemes
        {
            get => cbAllThemes.DataSource as IEnumerable<Theme>;
            set
            {
                cbAllThemes.ValueMember = "Id";
                cbAllThemes.DisplayMember = "Name";
                cbAllThemes.DataSource = value.Where(t => !Themes.Any(tt => tt.Id == t.Id)).ToList();
            }
        }

        public string FormTitle 
        { 
            get => this.Text; 
            set => this.Text = value; 
        }

        public int TestId { get; set; }

        public ComboBox AllThemesCb => cbAllThemes;

        public MetroGrid QuestionGr => grQuestions;

        public MetroGrid ThemeGr => grThemes;

        private void btLinkTheme_Click(object sender, EventArgs e)
        {
            if (cbAllThemes.SelectedItem == null)
            {
                return;
            }
            _presenter.LinkTheme((int)cbAllThemes.SelectedValue);
        }

        private void btDeleteLinkedTheme_Click(object sender, EventArgs e)
        {
            _presenter.DeleteTheme();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            _presenter.AddQuestion();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            _presenter.DeleteQuestion();
        }
    }
}
