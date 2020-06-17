using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diploma.Views;
using diploma.Models;
using diploma.Presenters;

namespace diploma.UI
{
    public partial class ThemesControl : UserControl, IThemesView
    {
        private readonly ThemeListPresenter _presenter;

        public ThemesControl()
        {
            InitializeComponent();
            _presenter = new ThemeListPresenter(this);
            _presenter.LoadThemes().ContinueWith((t) => _presenter.ConfigureGrid()).ConfigureAwait(true);
        }

        public List<Theme> Themes 
        { 
            get => metroGrid1.DataSource as List<Theme>; 
            set
            {
                _presenter.ConfigureGrid();
                metroGrid1.DataSource = value;
            } 
        }

        public DataGridView Grid => metroGrid1;

        private void materialButton1_Click(object sender, EventArgs e)
        {
            _presenter.LoadThemes();
        }

        private void metroGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _presenter.OpenTheme(e);
        }

        private void ThemesControl_Enter(object sender, EventArgs e)
        {
            _presenter.LoadThemes();
        }
    }
}
