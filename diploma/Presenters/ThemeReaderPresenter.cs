using diploma.Models;
using diploma.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void Print()
        {
            var saveForm = new SaveFileDialog();
            saveForm.DefaultExt = ".rtf";
            saveForm.FileName = $"{View.Theme.Name}.rtf";
            saveForm.AddExtension = true;
            saveForm.OverwritePrompt = true;
            saveForm.ShowDialog();
            File.WriteAllText(saveForm.FileName, View.Theme.Content);
        }
    }
}
