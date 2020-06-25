using diploma.Models;
using diploma.Presenters;
using diploma.Views;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma
{
    public partial class ResultForm : MaterialForm, IResultView
    {
        private List<Result> _results;
        private readonly ResultPresenter _presenter;
        public ResultForm(Result result)
        {
            InitializeComponent();
            _results = new List<Result>();
            _presenter = new ResultPresenter(this);
            _presenter.LoadResult(result.Id);
        }

        public int ResultId { get; set; }
        public int TestId { get; set; }
        public int UserId { get; set; }
        public int Points { get; set; }
        public List<Result> Results 
        { 
            get => _results;
            set 
            {
                _results = value;
                List<ResultView> ds = new List<ResultView>();
                var orderedCollection = _results.OrderByDescending(r => r.Score).ToList();
                foreach (var item in orderedCollection)
                {

                    ds.Add(new ResultView
                    {
                        Place = orderedCollection.IndexOf(item), 
                        Name = item.User.UserName, 
                        Points = item.Score
                    });
                }

                grRanking.DataSource = ds;

                grRanking.Columns[0].HeaderText = "Номер";
                grRanking.Columns[1].HeaderText = "Имя";
                grRanking.Columns[2].HeaderText = "Очки";
                grRanking.ReadOnly = true;
                grRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            } 
        }
        public string UserRank { get => txtResultText.Text; set => txtResultText.Text = value; }

        public class ResultView
        {
            public int Place { get; set; }
            public string Name { get; set; }
            public int Points { get; set; }
        }
    }
}
