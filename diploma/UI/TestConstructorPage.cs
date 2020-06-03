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

namespace diploma.UI
{
    public partial class TestConstructorPage : UserControl, IAddTestView
    {
        private readonly AddTestPresenter _presenter;

        public TestConstructorPage()
        {
            InitializeComponent();
            _presenter = new AddTestPresenter(this);
        }

        public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
        public string Time { get => txtTestTime.Text; set => txtTestTime.Text = value; }
        public string Message { get => txtMessage.Text; set => txtMessage.Text = value; }
        public string TestName { get => txtTestName.Text; set => txtTestName.Text = value; }

        private void btAddTest_Click(object sender, EventArgs e)
        {
            _presenter.AddTheme();
        }
    }
}
