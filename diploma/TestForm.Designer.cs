namespace diploma
{
    partial class TestForm
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
            this.listVariants = new System.Windows.Forms.CheckedListBox();
            this.txtQuestionNumber = new System.Windows.Forms.Label();
            this.txtQuestion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btEndTest = new MaterialSkin.Controls.MaterialButton();
            this.btNext = new MaterialSkin.Controls.MaterialButton();
            this.btPrevious = new MaterialSkin.Controls.MaterialButton();
            this.txtTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listVariants
            // 
            this.listVariants.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listVariants.FormattingEnabled = true;
            this.listVariants.Location = new System.Drawing.Point(12, 313);
            this.listVariants.Name = "listVariants";
            this.listVariants.Size = new System.Drawing.Size(622, 229);
            this.listVariants.TabIndex = 2;
            this.listVariants.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listVariants_ItemCheck);
            // 
            // txtQuestionNumber
            // 
            this.txtQuestionNumber.AutoSize = true;
            this.txtQuestionNumber.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQuestionNumber.Location = new System.Drawing.Point(329, 71);
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.Size = new System.Drawing.Size(149, 33);
            this.txtQuestionNumber.TabIndex = 4;
            this.txtQuestionNumber.Text = "Вопрос № ";
            this.txtQuestionNumber.Visible = false;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.Depth = 0;
            this.txtQuestion.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtQuestion.Hint = "";
            this.txtQuestion.Location = new System.Drawing.Point(13, 116);
            this.txtQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(621, 182);
            this.txtQuestion.TabIndex = 5;
            this.txtQuestion.Text = "";
            // 
            // btEndTest
            // 
            this.btEndTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btEndTest.Depth = 0;
            this.btEndTest.DrawShadows = true;
            this.btEndTest.HighEmphasis = true;
            this.btEndTest.Icon = null;
            this.btEndTest.Location = new System.Drawing.Point(485, 71);
            this.btEndTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btEndTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEndTest.Name = "btEndTest";
            this.btEndTest.Size = new System.Drawing.Size(148, 36);
            this.btEndTest.TabIndex = 6;
            this.btEndTest.Text = "Закончить тест";
            this.btEndTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btEndTest.UseAccentColor = true;
            this.btEndTest.UseVisualStyleBackColor = true;
            this.btEndTest.Click += new System.EventHandler(this.btEndTest_Click);
            // 
            // btNext
            // 
            this.btNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btNext.Depth = 0;
            this.btNext.DrawShadows = true;
            this.btNext.HighEmphasis = true;
            this.btNext.Icon = global::diploma.Properties.Resources.outline_keyboard_arrow_right_black_18dp;
            this.btNext.Location = new System.Drawing.Point(521, 551);
            this.btNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(112, 36);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "Дальше";
            this.btNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btNext.UseAccentColor = false;
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrevious
            // 
            this.btPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btPrevious.Depth = 0;
            this.btPrevious.DrawShadows = true;
            this.btPrevious.HighEmphasis = true;
            this.btPrevious.Icon = global::diploma.Properties.Resources.outline_keyboard_arrow_left_black_18dp;
            this.btPrevious.Location = new System.Drawing.Point(13, 551);
            this.btPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btPrevious.MouseState = MaterialSkin.MouseState.HOVER;
            this.btPrevious.Name = "btPrevious";
            this.btPrevious.Size = new System.Drawing.Size(99, 36);
            this.btPrevious.TabIndex = 0;
            this.btPrevious.Text = "Назад";
            this.btPrevious.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btPrevious.UseAccentColor = false;
            this.btPrevious.UseVisualStyleBackColor = true;
            this.btPrevious.Click += new System.EventHandler(this.btPrevious_Click);
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTime.Location = new System.Drawing.Point(7, 68);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(82, 33);
            this.txtTime.TabIndex = 7;
            this.txtTime.Text = "00:00";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 602);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.btEndTest);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtQuestionNumber);
            this.Controls.Add(this.listVariants);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btPrevious);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btPrevious;
        private MaterialSkin.Controls.MaterialButton btNext;
        private System.Windows.Forms.CheckedListBox listVariants;
        private System.Windows.Forms.Label txtQuestionNumber;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtQuestion;
        private MaterialSkin.Controls.MaterialButton btEndTest;
        private System.Windows.Forms.Label txtTime;
    }
}