using diploma.Models;
using diploma.Views;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diploma.Presenters
{
    public class AddThemePresenter : GenericPresenter<IAddThemeView>
    {
        public AddThemePresenter(IAddThemeView view) : base(view)
        {
        }

        public void AddTheme()
        {
            View.Message = string.Empty;

            #region validation
            if (string.IsNullOrEmpty(View.ThemeName))
            {
                View.Message = "Введите название темы!";
                return;
            }
            if (View.Content.Text.Length < 5)
            {
                View.Message = "Содержание темы должно быть не меньше 5 символов!";
                return;
            }
            #endregion

            var theme = new Theme
            {
                Content = View.Content.Rtf,
                Name = View.ThemeName,
            };

            using (var context = new Context())
            {
                context.Themes.Add(theme);
                context.SaveChanges();
                MaterialMessageBox.Show("Тема добавлена!");
                View.ThemeName = string.Empty;
                View.Content.Text = string.Empty;
            }
        }
    }
}
