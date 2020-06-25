using diploma.Models;
using diploma.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma.Presenters
{
    public class ThemeListPresenter : GenericPresenter<IThemesView>
    {
        public ThemeListPresenter(IThemesView view) : base(view)
        {
        }

        public async Task LoadThemes()
        {
            using (var context = new Context())
            {
                var themes = await context.Themes
                    .Select(t => new { t.Id, t.Name })
                    .ToListAsync();
                View.Themes = themes.Select(t => new Theme { Id = t.Id, Name = t.Name }).ToList();
                var subjects = context.Subjects.ToList();
                subjects.Add(new Subject { Id = -1, Alias = "Все" });
                View.Subjects = subjects;
            }
        }

        public void ConfigureGrid()
        {
            var c = View.Grid.Columns;
            foreach (var item in c.Cast<DataGridViewColumn>())
            {
                item.Visible = false;
            }
            if (HasColumn("Name"))
            {
                View.Grid.Columns["Name"].Visible = true;
                View.Grid.Columns["Name"].HeaderText = "Название темы";
            }
            View.Grid.ReadOnly = true;
            View.Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void OpenTheme(DataGridViewCellEventArgs e)
        {
            var theme = View.Grid.Rows[e.RowIndex].DataBoundItem as Theme;
            var form = new ThemeReader(theme);
            form.ShowDialog();
        }

        private bool HasColumn(string name)
        {
            return View.Grid.Columns
                .Cast<DataGridViewColumn>()
                .Any(c => c.Name == name);
        }

        internal void FilterTheme()
        {
            using var context = new Context();
            if (View.SelectedSubject.Id == -1)
            {
                View.Themes = context.Themes.ToList();
                return;
            }
            View.Themes = context.Themes
                .Where(t => t.SubjectId == View.SelectedSubject.Id)
                .ToList();
        }
    }
}
