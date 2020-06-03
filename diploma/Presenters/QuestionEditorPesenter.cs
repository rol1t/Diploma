using diploma.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class QuestionEditorPresenter : GenericPresenter<IQuestionEditorView>
    {
        public QuestionEditorPresenter(IQuestionEditorView view) : base(view)
        {
        }
    }
}
