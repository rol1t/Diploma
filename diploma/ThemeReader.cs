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
    public partial class ThemeReader : MaterialForm, IThemeReaderView
    {
        private readonly ThemeReaderPresenter _presenter;

        public ThemeReader(Theme theme)
        {
            InitializeComponent();
            this.Theme = theme;
            _presenter = new ThemeReaderPresenter(this);
        }

        public Theme Theme { get; set; }
        public string HeaderText { get => this.Text; set => this.Text = value; }
        public string Content { get => richTextBox1.Rtf; set => richTextBox1.Rtf = value; }

        private void ThemeReader_Load(object sender, EventArgs e)
        {
            _presenter.LoadTheme();
        }
    }
}
