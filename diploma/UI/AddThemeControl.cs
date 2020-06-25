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

namespace diploma.UI
{
    public partial class AddThemeControl : UserControl, IAddThemeView
    {
        private readonly AddThemePresenter _presenter;
        public AddThemeControl()
        {
            InitializeComponent();
            _presenter = new AddThemePresenter(this);
        }

        public string ThemeName { get => txtThemeName.Text; set => txtThemeName.Text = value; }
        public string Message { get => txtMessage.Text; set => txtMessage.Text = value; }
        public List<Subject> Subjects 
        { 
            get => cbSubjects.DataSource as List<Subject>; 
            set 
            { 
                cbSubjects.DataSource = value;
                cbSubjects.ValueMember = "Id";
                cbSubjects.DisplayMember = "Alias";
            } 
        }
        public Subject SelectedSubject { get => cbSubjects.SelectedItem as Subject; }
        RichTextBoxEx.RichTextBoxEx IAddThemeView.Content { get => txtContent1; }

        private void btAddTheme_Click(object sender, EventArgs e)
        {
            _presenter.AddTheme();
        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            _presenter.Load();
        }

        private void cbSubjects_Enter(object sender, EventArgs e)
        {
            _presenter.Load();
        }
    }
}
