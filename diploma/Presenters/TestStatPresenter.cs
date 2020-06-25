using diploma.Models;
using diploma.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using Xceed.Words.NET;
using static diploma.TestStatForm;

namespace diploma.Presenters
{
    public class TestStatPresenter : GenericPresenter<ITestStatView>
    {
        public TestStatPresenter(ITestStatView view) : base(view)
        {
        }

        public void Load(int testId)
        {
            using var context = new Context();
            var test = context.Tests
                .Include(t => t.Questions)
                .Include(t => t.Results)
                .ThenInclude(t => t.User)
                .FirstOrDefault(t => t.Id == testId);
            View.TestScore = test.Questions.Sum(t => t.Points);
            decimal maxScore = test.Questions.Sum(t => t.Points);
            decimal avgScore = (decimal)test.Results.Average(r => r.Score);
            var avgProcent = Math.Round(avgScore / maxScore, 2) * 100;
            View.TestName = $"Статистика теста {test.Name}";
            View.Count = $"Количество прохождений: {test.Results.Count()}";
            View.AvgProcent = $"Средний процент прохождений: {avgProcent}%";
            View.Results = test.Results;
        }

        internal void Print()
        {
            var saveForm = new SaveFileDialog();
            saveForm.DefaultExt = ".docx";
            saveForm.AddExtension = true;
            saveForm.FileName = $"{View.TestName}.docx";
            saveForm.ShowDialog();
            var results = View.ResultViews;
            var doc = DocX.Create(saveForm.FileName);
            var header = doc.InsertParagraph();
            header.AppendLine(View.TestName).FontSize(20).Bold();
            header.AppendLine();
            header.AppendLine(View.Count).FontSize(14);
            header.AppendLine(View.AvgProcent).FontSize(14);
            header.AppendLine($"Максимальное количество очков: {View.TestScore}").FontSize(14);
            header.AppendLine();
            var table = doc.InsertTable(results.Count() + 1, 3);
            table.Rows[0].Cells[0].Paragraphs[0].Append("Имя").Bold();
            table.Rows[0].Cells[1].Paragraphs[0].Append("Баллы").Bold();
            table.Rows[0].Cells[2].Paragraphs[0].Append("Процент прохождения").Bold();
            for (int i = 1; i <= results.Count; i++)
            {
                table.Rows[i].Cells[0].Paragraphs[0].Append(results[i - 1].UserName);
                table.Rows[i].Cells[1].Paragraphs[0].Append(results[i - 1].Score.ToString());
                table.Rows[i].Cells[2].Paragraphs[0].Append(results[i - 1].Procent.ToString());
            }
            doc.Save();
        }
    }
}
