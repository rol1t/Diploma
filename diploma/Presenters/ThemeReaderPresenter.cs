using diploma.Models;
using diploma.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class ThemeReaderPresenter : GenericPresenter<IThemeReaderView>
    {
        public ThemeReaderPresenter(IThemeReaderView view) : base(view)
        {
        }

        public void LoadTheme()
        {
            using (var context = new Context())
            {
                View.Theme = context.Themes.FirstOrDefault(t => t.Id == View.Theme.Id);
                View.HeaderText = View.Theme.Name;
                View.Content = View.Theme.Content;
            }
        }
    }
}
