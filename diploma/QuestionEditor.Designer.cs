namespace diploma
{
    partial class QuestionEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtQuestionName = new MaterialSkin.Controls.MaterialTextBox();
            this.btAddVariant = new MaterialSkin.Controls.MaterialButton();
            this.cblVariants = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.txtVariant = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSaveQuestion = new MaterialSkin.Controls.MaterialButton();
            this.cbIsMulti = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 161);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(351, 294);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "";
            // 
            // txtQuestionName
            // 
            this.txtQuestionName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestionName.Depth = 0;
            this.txtQuestionName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtQuestionName.Hint = "Заголовок вопроса";
            this.txtQuestionName.Location = new System.Drawing.Point(12, 72);
            this.txtQuestionName.MaxLength = 50;
            this.txtQuestionName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuestionName.Multiline = false;
            this.txtQuestionName.Name = "txtQuestionName";
            this.txtQuestionName.Size = new System.Drawing.Size(855, 50);
            this.txtQuestionName.TabIndex = 1;
            this.txtQuestionName.Text = "";
            // 
            // btAddVariant
            // 
            this.btAddVariant.AutoSize = false;
            this.btAddVariant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddVariant.Depth = 0;
            this.btAddVariant.DrawShadows = true;
            this.btAddVariant.HighEmphasis = true;
            this.btAddVariant.Icon = null;
            this.btAddVariant.Location = new System.Drawing.Point(758, 504);
            this.btAddVariant.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddVariant.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddVariant.Name = "btAddVariant";
            this.btAddVariant.Size = new System.Drawing.Size(109, 36);
            this.btAddVariant.TabIndex = 2;
            this.btAddVariant.Text = "Добавить";
            this.btAddVariant.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btAddVariant.UseAccentColor = false;
            this.btAddVariant.UseVisualStyleBackColor = true;
            // 
            // cblVariants
            // 
            this.cblVariants.AutoScroll = true;
            this.cblVariants.BackColor = System.Drawing.SystemColors.Control;
            this.cblVariants.Depth = 0;
            this.cblVariants.Location = new System.Drawing.Point(369, 161);
            this.cblVariants.MouseState = MaterialSkin.MouseState.HOVER;
            this.cblVariants.Name = "cblVariants";
            this.cblVariants.Size = new System.Drawing.Size(498, 294);
            this.cblVariants.Striped = false;
            this.cblVariants.StripeDarkColor = System.Drawing.Color.Empty;
            this.cblVariants.TabIndex = 3;
            // 
            // txtVariant
            // 
            this.txtVariant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVariant.Depth = 0;
            this.txtVariant.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtVariant.Hint = "Текст варианта ответа";
            this.txtVariant.Location = new System.Drawing.Point(369, 465);
            this.txtVariant.MaxLength = 50;
            this.txtVariant.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVariant.Multiline = false;
            this.txtVariant.Name = "txtVariant";
            this.txtVariant.Size = new System.Drawing.Size(498, 36);
            this.txtVariant.TabIndex = 4;
            this.txtVariant.Text = "";
            this.txtVariant.UseTallSize = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Описание вопроса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(363, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Варианты ответа";
            // 
            // btSaveQuestion
            // 
            this.btSaveQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSaveQuestion.Depth = 0;
            this.btSaveQuestion.DrawShadows = true;
            this.btSaveQuestion.HighEmphasis = true;
            this.btSaveQuestion.Icon = null;
            this.btSaveQuestion.Location = new System.Drawing.Point(12, 504);
            this.btSaveQuestion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSaveQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSaveQuestion.Name = "btSaveQuestion";
            this.btSaveQuestion.Size = new System.Drawing.Size(172, 36);
            this.btSaveQuestion.TabIndex = 7;
            this.btSaveQuestion.Text = "Сохранить вопрос";
            this.btSaveQuestion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btSaveQuestion.UseAccentColor = false;
            this.btSaveQuestion.UseVisualStyleBackColor = true;
            // 
            // cbIsMulti
            // 
            this.cbIsMulti.Depth = 0;
            this.cbIsMulti.Location = new System.Drawing.Point(369, 504);
            this.cbIsMulti.Margin = new System.Windows.Forms.Padding(0);
            this.cbIsMulti.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbIsMulti.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbIsMulti.Name = "cbIsMulti";
            this.cbIsMulti.Ripple = true;
            this.cbIsMulti.Size = new System.Drawing.Size(357, 36);
            this.cbIsMulti.TabIndex = 8;
            this.cbIsMulti.Text = "У вопроса несколько вариантров ответа";
            this.cbIsMulti.UseVisualStyleBackColor = true;
            // 
            // QuestionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 554);
            this.Controls.Add(this.cbIsMulti);
            this.Controls.Add(this.btSaveQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVariant);
            this.Controls.Add(this.cblVariants);
            this.Controls.Add(this.btAddVariant);
            this.Controls.Add(this.txtQuestionName);
            this.Controls.Add(this.txtDescription);
            this.Name = "QuestionEditor";
            this.Text = "QuestionEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDescription;
        private MaterialSkin.Controls.MaterialTextBox txtQuestionName;
        private MaterialSkin.Controls.MaterialButton btAddVariant;
        private MaterialSkin.Controls.MaterialCheckedListBox cblVariants;
        private MaterialSkin.Controls.MaterialTextBox txtVariant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton btSaveQuestion;
        private MaterialSkin.Controls.MaterialCheckbox cbIsMulti;
    }
}