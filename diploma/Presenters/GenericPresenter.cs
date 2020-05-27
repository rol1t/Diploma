using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class GenericPresenter<TView>
    {
        public TView View { get; set; }

        public GenericPresenter(TView view)
        {
            View = view;
        }
    }
}
