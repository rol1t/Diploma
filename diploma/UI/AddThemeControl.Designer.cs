namespace diploma.UI
{
    partial class AddThemeControl
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
            this.txtThemeName = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddTheme = new MaterialSkin.Controls.MaterialButton();
            this.textBoxContextMenuStrip1 = new MaterialSkin.Controls.TextBoxContextMenuStrip();
            this.txtMessage = new System.Windows.Forms.Label();
            this.txtContent1 = new RichTextBoxEx.RichTextBoxEx();
            this.SuspendLayout();
            // 
            // txtThemeName
            // 
            this.txtThemeName.BackColor = System.Drawing.Color.White;
            this.txtThemeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThemeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThemeName.Depth = 0;
            this.txtThemeName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtThemeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtThemeName.Hint = "Название темы";
            this.txtThemeName.Location = new System.Drawing.Point(214, 14);
            this.txtThemeName.MaxLength = 50;
            this.txtThemeName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtThemeName.Multiline = false;
            this.txtThemeName.Name = "txtThemeName";
            this.txtThemeName.Size = new System.Drawing.Size(220, 36);
            this.txtThemeName.TabIndex = 3;
            this.txtThemeName.Text = "";
            this.txtThemeName.UseAccent = false;
            this.txtThemeName.UseTallSize = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавить тему";
            // 
            // btAddTheme
            // 
            this.btAddTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddTheme.Depth = 0;
            this.btAddTheme.DrawShadows = true;
            this.btAddTheme.HighEmphasis = true;
            this.btAddTheme.Icon = null;
            this.btAddTheme.Location = new System.Drawing.Point(851, 17);
            this.btAddTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddTheme.Name = "btAddTheme";
            this.btAddTheme.Size = new System.Drawing.Size(100, 36);
            this.btAddTheme.TabIndex = 6;
            this.btAddTheme.Text = "Добавить";
            this.btAddTheme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAddTheme.UseAccentColor = false;
            this.btAddTheme.UseVisualStyleBackColor = true;
            this.btAddTheme.Click += new System.EventHandler(this.btAddTheme_Click);
            // 
            // textBoxContextMenuStrip1
            // 
            this.textBoxContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.textBoxContextMenuStrip1.Depth = 0;
            this.textBoxContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxContextMenuStrip1.Name = "textBoxContextMenuStrip1";
            this.textBoxContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.textBoxContextMenuStrip1.Size = new System.Drawing.Size(123, 160);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Roboto", 14.14F);
            this.txtMessage.ForeColor = System.Drawing.Color.Red;
            this.txtMessage.Location = new System.Drawing.Point(440, 14);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(404, 53);
            this.txtMessage.TabIndex = 10;
            // 
            // txtContent1
            // 
            this.txtContent1.AllowBullets = true;
            this.txtContent1.AllowDefaultInsertText = true;
            this.txtContent1.AllowDefaultSmartText = true;
            this.txtContent1.AllowHyphenation = true;
            this.txtContent1.AllowPictures = true;
            this.txtContent1.AllowSpellCheck = false;
            this.txtContent1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtContent1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent1.FilePath = "";
            this.txtContent1.Location = new System.Drawing.Point(5, 70);
            this.txtContent1.Name = "txtContent1";
            this.txtContent1.Rtf = "{\\rtf1\\ansi\\ansicpg1251\\deff0\\nouicompat{\\fonttbl{\\f0\\fnil\\fcharset204 Arial;}}\r\n" +
    "{\\*\\generator Riched20 10.0.18362}\\viewkind4\\uc1 \r\n\\pard\\f0\\fs20\\lang1049\\\'d2\\\'e" +
    "5\\\'ea\\\'f1\\\'f2\\par\r\n}\r\n";
            this.txtContent1.SetColorWithFont = true;
            this.txtContent1.ShowToolStrip = true;
            this.txtContent1.Size = new System.Drawing.Size(950, 474);
            this.txtContent1.TabIndex = 11;
            // 
            // AddThemeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtContent1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btAddTheme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThemeName);
            this.Name = "AddThemeControl";
            this.Padding = new System.Windows.Forms.Padding(5, 70, 5, 5);
            this.Size = new System.Drawing.Size(960, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtThemeName;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btAddTheme;
        private MaterialSkin.Controls.TextBoxContextMenuStrip textBoxContextMenuStrip1;
        private System.Windows.Forms.Label txtMessage;
        private RichTextBoxEx.RichTextBoxEx txtContent1;
    }
}
