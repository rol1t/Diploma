namespace diploma.UI
{
    partial class ProfilePage
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
            this.btLogout = new MaterialSkin.Controls.MaterialButton();
            this.txtLogin = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtAvgProcent = new System.Windows.Forms.Label();
            this.txtComplTest = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Профиль";
            // 
            // btLogout
            // 
            this.btLogout.AutoSize = false;
            this.btLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLogout.Depth = 0;
            this.btLogout.DrawShadows = true;
            this.btLogout.HighEmphasis = true;
            this.btLogout.Icon = null;
            this.btLogout.Location = new System.Drawing.Point(234, 213);
            this.btLogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btLogout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(147, 40);
            this.btLogout.TabIndex = 12;
            this.btLogout.Text = "Выход";
            this.btLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btLogout.UseAccentColor = true;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.AutoSize = true;
            this.txtLogin.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(17, 14);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(107, 23);
            this.txtLogin.TabIndex = 13;
            this.txtLogin.Text = "Логин: rolit";
            this.txtLogin.Click += new System.EventHandler(this.label2_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtAvgProcent);
            this.materialCard1.Controls.Add(this.txtComplTest);
            this.materialCard1.Controls.Add(this.txtRole);
            this.materialCard1.Controls.Add(this.txtName);
            this.materialCard1.Controls.Add(this.txtLogin);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(9, 47);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(372, 146);
            this.materialCard1.TabIndex = 14;
            // 
            // txtAvgProcent
            // 
            this.txtAvgProcent.AutoSize = true;
            this.txtAvgProcent.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAvgProcent.Location = new System.Drawing.Point(17, 106);
            this.txtAvgProcent.Name = "txtAvgProcent";
            this.txtAvgProcent.Size = new System.Drawing.Size(343, 23);
            this.txtAvgProcent.TabIndex = 17;
            this.txtAvgProcent.Text = "Средний процент прохождения: 90 %";
            this.txtAvgProcent.Visible = false;
            // 
            // txtComplTest
            // 
            this.txtComplTest.AutoSize = true;
            this.txtComplTest.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtComplTest.Location = new System.Drawing.Point(18, 83);
            this.txtComplTest.Name = "txtComplTest";
            this.txtComplTest.Size = new System.Drawing.Size(196, 23);
            this.txtComplTest.TabIndex = 16;
            this.txtComplTest.Text = "Пройдено тестов: 13";
            // 
            // txtRole
            // 
            this.txtRole.AutoSize = true;
            this.txtRole.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRole.Location = new System.Drawing.Point(18, 60);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(151, 23);
            this.txtRole.TabIndex = 15;
            this.txtRole.Text = "Роль: учащийся";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(18, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 23);
            this.txtName.TabIndex = 14;
            this.txtName.Text = "Имя: Гарицкий Алексей";
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label1);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(403, 282);
            this.Enter += new System.EventHandler(this.ProfilePage_Enter);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btLogout;
        private System.Windows.Forms.Label txtLogin;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label txtAvgProcent;
        private System.Windows.Forms.Label txtComplTest;
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.Label txtName;
    }
}
