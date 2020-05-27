namespace diploma.UI
{
    partial class AddUserPage
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
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUserName = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPasswordConfirm = new MaterialSkin.Controls.MaterialTextBox();
            this.swIsTeacher = new MaterialSkin.Controls.MaterialSwitch();
            this.btAddUser = new MaterialSkin.Controls.MaterialButton();
            this.txtError = new System.Windows.Forms.Label();
            this.materialButton10 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить пользователя";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.Hint = "Пароль";
            this.txtPassword.Location = new System.Drawing.Point(4, 167);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(426, 50);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "";
            // 
            // txtLogin
            // 
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Depth = 0;
            this.txtLogin.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLogin.Hint = "Логин";
            this.txtLogin.Location = new System.Drawing.Point(4, 55);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(426, 50);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Text = "";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Depth = 0;
            this.txtUserName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUserName.Hint = "Имя пользователя";
            this.txtUserName.Location = new System.Drawing.Point(4, 111);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(426, 50);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.Text = "";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordConfirm.Depth = 0;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPasswordConfirm.Hint = "Повторите пароль";
            this.txtPasswordConfirm.Location = new System.Drawing.Point(4, 223);
            this.txtPasswordConfirm.MaxLength = 50;
            this.txtPasswordConfirm.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPasswordConfirm.Multiline = false;
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Password = true;
            this.txtPasswordConfirm.Size = new System.Drawing.Size(426, 50);
            this.txtPasswordConfirm.TabIndex = 7;
            this.txtPasswordConfirm.Text = "";
            // 
            // swIsTeacher
            // 
            this.swIsTeacher.AutoSize = true;
            this.swIsTeacher.Depth = 0;
            this.swIsTeacher.Location = new System.Drawing.Point(4, 280);
            this.swIsTeacher.Margin = new System.Windows.Forms.Padding(0);
            this.swIsTeacher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swIsTeacher.MouseState = MaterialSkin.MouseState.HOVER;
            this.swIsTeacher.Name = "swIsTeacher";
            this.swIsTeacher.Ripple = true;
            this.swIsTeacher.Size = new System.Drawing.Size(150, 37);
            this.swIsTeacher.TabIndex = 8;
            this.swIsTeacher.Text = "Это учитель";
            this.swIsTeacher.UseVisualStyleBackColor = true;
            // 
            // btAddUser
            // 
            this.btAddUser.AutoSize = false;
            this.btAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddUser.Depth = 0;
            this.btAddUser.DrawShadows = true;
            this.btAddUser.HighEmphasis = true;
            this.btAddUser.Icon = null;
            this.btAddUser.Location = new System.Drawing.Point(272, 318);
            this.btAddUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(158, 40);
            this.btAddUser.TabIndex = 9;
            this.btAddUser.Text = "Добавить";
            this.btAddUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAddUser.UseAccentColor = false;
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // txtError
            // 
            this.txtError.AutoSize = true;
            this.txtError.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtError.Location = new System.Drawing.Point(3, 328);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(0, 19);
            this.txtError.TabIndex = 10;
            // 
            // materialButton10
            // 
            this.materialButton10.AutoSize = false;
            this.materialButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton10.Depth = 0;
            this.materialButton10.DrawShadows = true;
            this.materialButton10.HighEmphasis = true;
            this.materialButton10.Icon = null;
            this.materialButton10.Location = new System.Drawing.Point(7, 318);
            this.materialButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton10.Name = "materialButton10";
            this.materialButton10.Size = new System.Drawing.Size(147, 40);
            this.materialButton10.TabIndex = 11;
            this.materialButton10.Text = "Очистить";
            this.materialButton10.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton10.UseAccentColor = true;
            this.materialButton10.UseVisualStyleBackColor = true;
            this.materialButton10.Click += new System.EventHandler(this.materialButton10_Click);
            // 
            // AddUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialButton10);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.swIsTeacher);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Name = "AddUserPage";
            this.Size = new System.Drawing.Size(798, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialTextBox txtLogin;
        private MaterialSkin.Controls.MaterialTextBox txtUserName;
        private MaterialSkin.Controls.MaterialTextBox txtPasswordConfirm;
        private MaterialSkin.Controls.MaterialSwitch swIsTeacher;
        private MaterialSkin.Controls.MaterialButton btAddUser;
        private System.Windows.Forms.Label txtError;
        private MaterialSkin.Controls.MaterialButton materialButton10;
    }
}
