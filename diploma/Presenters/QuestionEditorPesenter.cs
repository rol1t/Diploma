﻿using diploma.Models;
using diploma.Views;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var q = context.Questions.FirstOrDefault(q => q.Id == View.QuestionId);
            View.IsMulti = q.IsMultiVariants;
            View.QuestionName = q.Name;
            View.Variants = q.Variants?.ToList() ?? new List<Variant>();
            View.Description = q.Description;
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

        public void SaveQuestion()
        {
            if (string.IsNullOrEmpty(View.QuestionName))
            {
                MaterialMessageBox.Show("Ошибка", "Введите заголовок вопроса!", 
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(View.Description))
            {
                MaterialMessageBox.Show("Ошибка", "Введите описание вопроса!",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
            if (View.Variants.Count < 1)
            {
                MaterialMessageBox.Show("Ошибка", "Вариантов ответа должно быть не меньше 2-х!",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
            using var context = new Context();
            var question = new Question
            {
                Id = View.QuestionId,
                Name = View.QuestionName,
                Description = View.Description,
                IsMultiVariants = View.IsMulti,
                Variants = View.Variants
            };
            context.Entry<Question>(question).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
