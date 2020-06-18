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
            this.txtVariant = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSaveQuestion = new MaterialSkin.Controls.MaterialButton();
            this.cbIsMulti = new MaterialSkin.Controls.MaterialCheckbox();
            this.cblVariants = new System.Windows.Forms.CheckedListBox();
            this.btDelete = new MaterialSkin.Controls.MaterialButton();
            this.txtPoints = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDescription.Location = new System.Drawing.Point(12, 161);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(351, 279);
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
            this.txtQuestionName.Size = new System.Drawing.Size(547, 50);
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
            this.btAddVariant.Location = new System.Drawing.Point(749, 503);
            this.btAddVariant.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddVariant.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddVariant.Name = "btAddVariant";
            this.btAddVariant.Size = new System.Drawing.Size(109, 36);
            this.btAddVariant.TabIndex = 2;
            this.btAddVariant.Text = "Добавить";
            this.btAddVariant.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btAddVariant.UseAccentColor = false;
            this.btAddVariant.UseVisualStyleBackColor = true;
            this.btAddVariant.Click += new System.EventHandler(this.btAddVariant_Click);
            // 
            // txtVariant
            // 
            this.txtVariant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVariant.Depth = 0;
            this.txtVariant.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtVariant.Hint = "Текст варианта ответа";
            this.txtVariant.Location = new System.Drawing.Point(375, 458);
            this.txtVariant.MaxLength = 500;
            this.txtVariant.MouseState = MaterialSkin.MouseState.OUT;
            this.txtVariant.Multiline = false;
            this.txtVariant.Name = "txtVariant";
            this.txtVariant.Size = new System.Drawing.Size(483, 36);
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
            this.btSaveQuestion.Click += new System.EventHandler(this.btSaveQuestion_Click);
            // 
            // cbIsMulti
            // 
            this.cbIsMulti.Depth = 0;
            this.cbIsMulti.Location = new System.Drawing.Point(12, 458);
            this.cbIsMulti.Margin = new System.Windows.Forms.Padding(0);
            this.cbIsMulti.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbIsMulti.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbIsMulti.Name = "cbIsMulti";
            this.cbIsMulti.Ripple = true;
            this.cbIsMulti.Size = new System.Drawing.Size(357, 36);
            this.cbIsMulti.TabIndex = 8;
            this.cbIsMulti.Text = "У вопроса несколько вариантров ответа";
            this.cbIsMulti.UseVisualStyleBackColor = true;
            this.cbIsMulti.CheckedChanged += new System.EventHandler(this.cbIsMulti_CheckedChanged);
            // 
            // cblVariants
            // 
            this.cblVariants.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cblVariants.FormattingEnabled = true;
            this.cblVariants.Location = new System.Drawing.Point(369, 161);
            this.cblVariants.Name = "cblVariants";
            this.cblVariants.Size = new System.Drawing.Size(489, 279);
            this.cblVariants.TabIndex = 9;
            this.cblVariants.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblVariants_ItemCheck);
            // 
            // btDelete
            // 
            this.btDelete.AutoSize = false;
            this.btDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDelete.Depth = 0;
            this.btDelete.DrawShadows = true;
            this.btDelete.HighEmphasis = true;
            this.btDelete.Icon = null;
            this.btDelete.Location = new System.Drawing.Point(632, 503);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(109, 36);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Удалить";
            this.btDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btDelete.UseAccentColor = true;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtPoints
            // 
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoints.Depth = 0;
            this.txtPoints.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPoints.Hint = "Количество баллов";
            this.txtPoints.Location = new System.Drawing.Point(565, 72);
            this.txtPoints.MaxLength = 50;
            this.txtPoints.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPoints.Multiline = false;
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(306, 50);
            this.txtPoints.TabIndex = 11;
            this.txtPoints.Text = "";
            // 
            // QuestionEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 554);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.cblVariants);
            this.Controls.Add(this.cbIsMulti);
            this.Controls.Add(this.btSaveQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVariant);
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
        private MaterialSkin.Controls.MaterialTextBox txtVariant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton btSaveQuestion;
        private MaterialSkin.Controls.MaterialCheckbox cbIsMulti;
        private System.Windows.Forms.CheckedListBox cblVariants;
        private MaterialSkin.Controls.MaterialButton btDelete;
        private MaterialSkin.Controls.MaterialTextBox txtPoints;
    }
}