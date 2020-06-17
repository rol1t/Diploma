namespace diploma.UI
{
    partial class TestConstructorPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestName = new MaterialSkin.Controls.MaterialTextBox();
            this.btAddTest = new MaterialSkin.Controls.MaterialButton();
            this.txtTestTime = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Конструктор тестов";
            // 
            // txtTestName
            // 
            this.txtTestName.BackColor = System.Drawing.Color.White;
            this.txtTestName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTestName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTestName.Depth = 0;
            this.txtTestName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTestName.Hint = "Название теста";
            this.txtTestName.Location = new System.Drawing.Point(10, 51);
            this.txtTestName.MaxLength = 50;
            this.txtTestName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTestName.Multiline = false;
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(444, 36);
            this.txtTestName.TabIndex = 4;
            this.txtTestName.Text = "";
            this.txtTestName.UseAccent = false;
            this.txtTestName.UseTallSize = false;
            // 
            // btAddTest
            // 
            this.btAddTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddTest.Depth = 0;
            this.btAddTest.DrawShadows = true;
            this.btAddTest.HighEmphasis = true;
            this.btAddTest.Icon = null;
            this.btAddTest.Location = new System.Drawing.Point(315, 296);
            this.btAddTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddTest.Name = "btAddTest";
            this.btAddTest.Size = new System.Drawing.Size(139, 36);
            this.btAddTest.TabIndex = 12;
            this.btAddTest.Text = "Добавить тест";
            this.btAddTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAddTest.UseAccentColor = false;
            this.btAddTest.UseVisualStyleBackColor = true;
            this.btAddTest.Click += new System.EventHandler(this.btAddTest_Click);
            // 
            // txtTestTime
            // 
            this.txtTestTime.BackColor = System.Drawing.Color.White;
            this.txtTestTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTestTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTestTime.Depth = 0;
            this.txtTestTime.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTestTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTestTime.Hint = "Время проведения теста (в минутах)";
            this.txtTestTime.Location = new System.Drawing.Point(10, 93);
            this.txtTestTime.MaxLength = 50;
            this.txtTestTime.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTestTime.Multiline = false;
            this.txtTestTime.Name = "txtTestTime";
            this.txtTestTime.Size = new System.Drawing.Size(444, 36);
            this.txtTestTime.TabIndex = 13;
            this.txtTestTime.Text = "";
            this.txtTestTime.UseAccent = false;
            this.txtTestTime.UseTallSize = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Depth = 0;
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescription.Hint = "";
            this.txtDescription.Location = new System.Drawing.Point(10, 158);
            this.txtDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(444, 129);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Описание теста";
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMessage.Location = new System.Drawing.Point(13, 359);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(0, 23);
            this.txtMessage.TabIndex = 16;
            // 
            // TestConstructorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTestTime);
            this.Controls.Add(this.btAddTest);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.label1);
            this.Name = "TestConstructorPage";
            this.Padding = new System.Windows.Forms.Padding(10, 90, 10, 50);
            this.Size = new System.Drawing.Size(964, 612);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtTestName;
        private MaterialSkin.Controls.MaterialButton btAddTest;
        private MaterialSkin.Controls.MaterialTextBox txtTestTime;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtMessage;
    }
}
