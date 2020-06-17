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
    public partial class TestForm : MaterialForm, ITestView
    {
        private readonly TestPresenter _presenter;
        public int questionNumber { get; set; }
        public TestForm(int testId)
        {
            InitializeComponent();
            _presenter = new TestPresenter(this);
            _presenter.LoadTest(testId);
        }

        public string TestName { get => this.Text; set => this.Text = value; }
        public List<Question> Questions { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan CurrentTime { get; set; }
        public Result Result { get; set; }
        public bool EndButtonVisible { get => btEndTest.Visible; set => btEndTest.Visible = value; }
        public bool PreviousQuestionButtonEnable { get => btPrevious.Enabled; set => btPrevious.Enabled = value; }
        public bool NextQuestionButtonEnable { get => btNext.Enabled; set => btNext.Enabled = value; }
        public Question CurrentQuestion 
        { 
            get 
            {
                return new Question
                {
                    Id = QuestionId,
                    Variants = Variants,
                    IsMultiVariants = IsMultiVariant,
                    Description = this.QuestionDescription
                };
            }
            set 
            {
                QuestionId = value.Id;
                QuestionTitle = value.Name;
                QuestionDescription = value.Description;
                Variants = value.Variants.ToList();
            }
        }
        public int QuestionId { get; set; }
        public string QuestionTitle { get => txtQuestion.Text; set => txtQuestion.Text = value; }
        public string QuestionDescription { get => txtQuestion.Text; set => txtQuestion.Text = value; }
        public List<Variant> Variants { get; set; }
        public int QuestionNumber 
        { 
            get => questionNumber; 
            set 
            {
                questionNumber = value;
                txtQuestionNumber.Text = $"Вопрос №{value}";
            } 
        }

        public CheckedListBox VariantListView { get => listVariants; }
        public bool IsMultiVariant { get; set; }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            _presenter.PreviousQuestion();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            _presenter.NextQuestion();
        }
    }
}
