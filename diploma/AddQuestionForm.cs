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
    public partial class AddQuestionForm : MaterialForm, IAddQuestionView
    {
        private readonly AddQuestionPresenter _presenter;
        public AddQuestionForm()
        {
            InitializeComponent();
            _presenter = new AddQuestionPresenter(this);
        }
    }
}
