using diploma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma.Views
{
    public interface ITestView
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public List<Question> Questions { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan CurrentTime { get; set; }
        public Result Result { get; set; }
        public int QuestionNumber { get; set; }
        public bool EndButtonVisible { get; set; }
        public bool PreviousQuestionButtonEnable { get; set; }
        public bool NextQuestionButtonEnable { get; set; }
        public Question CurrentQuestion { get; set; }
        public bool IsMultiVariant { get; set; }
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDescription { get; set; }
        public Action EndTest { get; set; }
        public List<Variant> Variants { get; set; }
        public CheckedListBox VariantListView { get; }
    }
}
