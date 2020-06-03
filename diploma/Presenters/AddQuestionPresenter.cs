using diploma.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class AddQuestionPresenter : GenericPresenter<IAddQuestionView>
    {
        public AddQuestionPresenter(IAddQuestionView view) : base(view)
        {
        }
    }
}
