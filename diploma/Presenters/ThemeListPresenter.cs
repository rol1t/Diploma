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
            }
        }

        public void ConfigureGrid()
        {
            var hiddenColumn = new[] { "Id", "Content" };
            foreach (var item in hiddenColumn)
            {
                if (HasColumn(item))
                {
                    View.Grid.Columns[item].Visible = false;
                }
            }
            if (HasColumn("Name"))
            {
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
    }
}
