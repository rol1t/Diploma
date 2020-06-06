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
    public partial class QuestionEditor : MaterialForm, IQuestionEditorView
    {
        private readonly QuestionEditorPresenter _presenter;

        public QuestionEditor(int questionId)
        {
            InitializeComponent();
            _presenter = new QuestionEditorPresenter(this);
            QuestionId = questionId;
            _presenter.LoadQuestion();
        }

        public int QuestionId { get; set; }
        public string QuestionName { get => txtQuestionName.Text; set => txtQuestionName.Text = value; }
        public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
        public bool IsMulti { get => cbIsMulti.Checked; set => cbIsMulti.Checked = value; }
        public string VariantName { get => txtVariant.Text; set => txtVariant.Text = value; }
        public List<Variant> Variants { get; set; }
        public CheckedListBox VariantList { get => cblVariants; }

        private void cblVariants_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var item = e;
            _presenter.ChangeVariant(cblVariants.Items[e.Index].ToString(), e.NewValue == CheckState.Checked);
        }

        private void btAddVariant_Click(object sender, EventArgs e)
        {
            _presenter.AddVariant();
        }

        private void cbIsMulti_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.CheckMultiVariant();
        }

        private void btSaveQuestion_Click(object sender, EventArgs e)
        {
            _presenter.SaveQuestion();
            Close();
        }
    }
}
