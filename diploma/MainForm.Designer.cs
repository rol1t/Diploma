namespace diploma
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.addTestPage = new System.Windows.Forms.TabPage();
            this.addUserPage = new System.Windows.Forms.TabPage();
            this.addUserPage1 = new diploma.UI.AddUserPage();
            this.testsPage = new System.Windows.Forms.TabPage();
            this.themesPage = new System.Windows.Forms.TabPage();
            this.profilePage = new System.Windows.Forms.TabPage();
            this.profilePage1 = new diploma.UI.ProfilePage();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.mcAddTheme = new System.Windows.Forms.TabPage();
            this.addThemeControl1 = new diploma.UI.AddThemeControl();
            this.msTabControl.SuspendLayout();
            this.addUserPage.SuspendLayout();
            this.profilePage.SuspendLayout();
            this.mcAddTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // msTabControl
            // 
            this.msTabControl.Controls.Add(this.addTestPage);
            this.msTabControl.Controls.Add(this.addUserPage);
            this.msTabControl.Controls.Add(this.testsPage);
            this.msTabControl.Controls.Add(this.themesPage);
            this.msTabControl.Controls.Add(this.profilePage);
            this.msTabControl.Controls.Add(this.mcAddTheme);
            this.msTabControl.Depth = 0;
            this.msTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msTabControl.ImageList = this.menuIconList;
            this.msTabControl.ItemSize = new System.Drawing.Size(70, 27);
            this.msTabControl.Location = new System.Drawing.Point(3, 64);
            this.msTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.msTabControl.Name = "msTabControl";
            this.msTabControl.SelectedIndex = 0;
            this.msTabControl.Size = new System.Drawing.Size(1023, 555);
            this.msTabControl.TabIndex = 0;
            // 
            // addTestPage
            // 
            this.addTestPage.ImageKey = "baseline_add_white_24dp.png";
            this.addTestPage.Location = new System.Drawing.Point(4, 31);
            this.addTestPage.Name = "addTestPage";
            this.addTestPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTestPage.Size = new System.Drawing.Size(1015, 520);
            this.addTestPage.TabIndex = 0;
            this.addTestPage.Text = "Добавить тест";
            this.addTestPage.UseVisualStyleBackColor = true;
            // 
            // addUserPage
            // 
            this.addUserPage.Controls.Add(this.addUserPage1);
            this.addUserPage.ImageKey = "outline_people_white_24dp.png";
            this.addUserPage.Location = new System.Drawing.Point(4, 31);
            this.addUserPage.Name = "addUserPage";
            this.addUserPage.Padding = new System.Windows.Forms.Padding(3);
            this.addUserPage.Size = new System.Drawing.Size(1015, 520);
            this.addUserPage.TabIndex = 1;
            this.addUserPage.Text = "Пользователи";
            this.addUserPage.UseVisualStyleBackColor = true;
            // 
            // addUserPage1
            // 
            this.addUserPage1.BackColor = System.Drawing.Color.White;
            this.addUserPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addUserPage1.IsTeacher = false;
            this.addUserPage1.Location = new System.Drawing.Point(3, 3);
            this.addUserPage1.Login = "";
            this.addUserPage1.Message = "";
            this.addUserPage1.Name = "addUserPage1";
            this.addUserPage1.Password = "";
            this.addUserPage1.PasswordConfirmation = "";
            this.addUserPage1.Size = new System.Drawing.Size(1009, 514);
            this.addUserPage1.TabIndex = 0;
            this.addUserPage1.UserName = "";
            // 
            // testsPage
            // 
            this.testsPage.ImageKey = "baseline_done_outline_white_24dp.png";
            this.testsPage.Location = new System.Drawing.Point(4, 31);
            this.testsPage.Name = "testsPage";
            this.testsPage.Padding = new System.Windows.Forms.Padding(3);
            this.testsPage.Size = new System.Drawing.Size(1015, 520);
            this.testsPage.TabIndex = 2;
            this.testsPage.Text = "Тесты";
            this.testsPage.UseVisualStyleBackColor = true;
            // 
            // themesPage
            // 
            this.themesPage.ImageKey = "outline_library_books_white_24dp.png";
            this.themesPage.Location = new System.Drawing.Point(4, 31);
            this.themesPage.Name = "themesPage";
            this.themesPage.Padding = new System.Windows.Forms.Padding(3);
            this.themesPage.Size = new System.Drawing.Size(1015, 520);
            this.themesPage.TabIndex = 3;
            this.themesPage.Text = "Темы";
            this.themesPage.UseVisualStyleBackColor = true;
            // 
            // profilePage
            // 
            this.profilePage.Controls.Add(this.profilePage1);
            this.profilePage.ImageKey = "baseline_perm_identity_white_24dp.png";
            this.profilePage.Location = new System.Drawing.Point(4, 31);
            this.profilePage.Name = "profilePage";
            this.profilePage.Padding = new System.Windows.Forms.Padding(3);
            this.profilePage.Size = new System.Drawing.Size(1015, 520);
            this.profilePage.TabIndex = 4;
            this.profilePage.Text = "Профиль";
            this.profilePage.UseVisualStyleBackColor = true;
            // 
            // profilePage1
            // 
            this.profilePage1.BackColor = System.Drawing.Color.White;
            this.profilePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePage1.ForeColor = System.Drawing.Color.Black;
            this.profilePage1.Location = new System.Drawing.Point(3, 3);
            this.profilePage1.Name = "profilePage1";
            this.profilePage1.Size = new System.Drawing.Size(1009, 514);
            this.profilePage1.TabIndex = 0;
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "baseline_done_outline_white_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "baseline_add_white_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "baseline_perm_identity_white_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "baseline_supervisor_account_white_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "outline_book_white_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "outline_people_white_24dp.png");
            this.menuIconList.Images.SetKeyName(6, "outline_library_books_white_24dp.png");
            // 
            // mcAddTheme
            // 
            this.mcAddTheme.Controls.Add(this.addThemeControl1);
            this.mcAddTheme.Location = new System.Drawing.Point(4, 31);
            this.mcAddTheme.Name = "mcAddTheme";
            this.mcAddTheme.Padding = new System.Windows.Forms.Padding(3);
            this.mcAddTheme.Size = new System.Drawing.Size(1015, 520);
            this.mcAddTheme.TabIndex = 5;
            this.mcAddTheme.Text = "Добавить тему";
            this.mcAddTheme.UseVisualStyleBackColor = true;
            // 
            // addThemeControl1
            // 
            this.addThemeControl1.BackColor = System.Drawing.Color.White;
            this.addThemeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addThemeControl1.Location = new System.Drawing.Point(3, 3);
            this.addThemeControl1.Message = "";
            this.addThemeControl1.Name = "addThemeControl1";
            this.addThemeControl1.Padding = new System.Windows.Forms.Padding(5, 70, 5, 5);
            this.addThemeControl1.Size = new System.Drawing.Size(1009, 514);
            this.addThemeControl1.TabIndex = 0;
            this.addThemeControl1.ThemeName = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 622);
            this.Controls.Add(this.msTabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.msTabControl;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning Engine Lite";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msTabControl.ResumeLayout(false);
            this.addUserPage.ResumeLayout(false);
            this.profilePage.ResumeLayout(false);
            this.mcAddTheme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialTabControl msTabControl;
        public System.Windows.Forms.TabPage addTestPage;
        public System.Windows.Forms.TabPage addUserPage;
        public System.Windows.Forms.TabPage testsPage;
        private System.Windows.Forms.TabPage themesPage;
        private System.Windows.Forms.ImageList menuIconList;
        private UI.AddUserPage addUserPage1;
        private System.Windows.Forms.TabPage profilePage;
        private UI.ProfilePage profilePage1;
        private System.Windows.Forms.TabPage mcAddTheme;
        private UI.AddThemeControl addThemeControl1;
    }
}

