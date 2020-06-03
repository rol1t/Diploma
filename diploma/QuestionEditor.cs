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

        public QuestionEditor()
        {
            InitializeComponent();
            _presenter = new QuestionEditorPresenter(this);
        }

        public int QuestionId { get; set; }
        public string QuestionName { get => txtQuestionName.Text; set => txtQuestionName.Text = value; }
        public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
        public bool IsMulti { get => cbIsMulti.Checked; set => cbIsMulti.Checked = value; }
        public List<Variant> Variants { get; set; }
        public Dictionary<string, bool> VariantsListItem
        { 
            get 
            {
                return Variants.Select(v => new KeyValuePair<string, bool>(v.Title, v.IsTrue))
                    .ToDictionary(k => k.Key, k => k.Value);
            } 
            set
            {

            }
        }
    }
}
