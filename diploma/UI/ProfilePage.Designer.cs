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
            this.btLogout.Location = new System.Drawing.Point(9, 39);
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
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.label1);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(847, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btLogout;
    }
}
