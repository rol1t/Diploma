using diploma.Models;
using diploma.Views;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma.Presenters
{
    public class QuestionEditorPresenter : GenericPresenter<IQuestionEditorView>
    {
        public QuestionEditorPresenter(IQuestionEditorView view) : base(view)
        {
        }

        public void LoadQuestion()
        {
            using var context = new Context();
            var q = context.Questions
                .Include(q => q.Variants)
                .FirstOrDefault(q => q.Id == View.QuestionId);
            View.IsMulti = q.IsMultiVariants;
            View.QuestionName = q.Name;
            View.Variants = q.Variants?.ToList() ?? new List<Variant>();
            View.Description = q.Description;
            View.Points = q.Points.ToString();
            UpdateVariantList();
        }

        public void AddVariant()
        {
            if (View.Variants.Any(v => v.Title == View.VariantName))
            {
                View.VariantName = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(View.VariantName))
            {
                return;
            }
            View.Variants.Add(new Variant { Title = View.VariantName });
            UpdateVariantList();
        }

        public void ChangeVariant(string variantName, bool value)
        {
            if (!View.Variants.Any(v => v.Title == variantName))
            {
                return;
            }
            CheckMultiVariant();
            var variant = View.Variants.FirstOrDefault(v => v.Title == variantName);
            variant.IsTrue = value;
        }

        public void CheckMultiVariant()
        {
            if (!View.IsMulti)
            {
                foreach (var item in View.Variants)
                {
                    item.IsTrue = false;
                }
                UpdateVariantList();
            }
        }

        public void DeleteVariant()
        {
            var values = View.VariantList.SelectedItems.Cast<string>();
            View.Variants = View.Variants.Where(v => values.Any(dv => dv != v.Title)).ToList();
            UpdateVariantList();
        }

        public void SaveQuestion()
        {
            if (string.IsNullOrEmpty(View.QuestionName))
            {
                MaterialMessageBox.Show("Ошибка", "Введите заголовок вопроса!", 
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            if (View.Variants.Count < 1)
            {
                MaterialMessageBox.Show("Ошибка", "Вариантов ответа должно быть не меньше 2-х!",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(View.Points, out var points))
            {
                MessageBox.Show("Ошибка", "Не верный формат баллов! (пример 1, 20, 40...)",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            }
            using var context = new Context();
            var question = context.Questions.FirstOrDefault(q => q.Id == View.QuestionId);
            question.Id = View.QuestionId;
            question.Name = View.QuestionName;
            question.Description = View.Description;
            question.IsMultiVariants = View.IsMulti;
            question.Points = points;
            var variants = View.Variants
                .Select(v => new Variant { Title = v.Title, IsTrue = v.IsTrue, QuestionId = View.QuestionId });
            context.Variants.RemoveRange(context.Variants.Where(v => v.QuestionId == View.QuestionId));
            context.Variants.AddRange(variants);
            context.SaveChanges();
        }

        private void UpdateVariantList()
        {
            View.VariantList.Items.Clear();
            foreach (var item in View.Variants)
            {
                View.VariantList.Items.Add(item.Title ?? string.Empty, item.IsTrue);
            }
        }
    }
}
