namespace diploma
{
    partial class TestEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grQuestions = new MetroFramework.Controls.MetroGrid();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btDelete = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grThemes = new MetroFramework.Controls.MetroGrid();
            this.cbAllThemes = new MaterialSkin.Controls.MaterialComboBox();
            this.btLinkTheme = new MaterialSkin.Controls.MaterialButton();
            this.btDeleteLinkedTheme = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grSubject = new MaterialSkin.Controls.MaterialComboBox();
            this.btSaveSubject = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.grQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThemes)).BeginInit();
            this.SuspendLayout();
            // 
            // grQuestions
            // 
            this.grQuestions.AllowUserToResizeRows = false;
            this.grQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grQuestions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            this.grQuestions.EnableHeadersVisualStyles = false;
            this.grQuestions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grQuestions.Location = new System.Drawing.Point(13, 110);
            this.grQuestions.Name = "grQuestions";
            this.grQuestions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grQuestions.RowHeadersVisible = false;
            this.grQuestions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            this.grQuestions.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grQuestions.RowTemplate.Height = 50;
            this.grQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grQuestions.Size = new System.Drawing.Size(476, 321);
            this.grQuestions.TabIndex = 1;
            this.grQuestions.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(13, 440);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(100, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Добавить";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btDelete
            // 
            this.btDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDelete.Depth = 0;
            this.btDelete.DrawShadows = true;
            this.btDelete.HighEmphasis = true;
            this.btDelete.Icon = null;
            this.btDelete.Location = new System.Drawing.Point(398, 440);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(91, 36);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Удалить";
            this.btDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btDelete.UseAccentColor = true;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Depth = 0;
            this.materialButton3.DrawShadows = true;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(121, 440);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(146, 36);
            this.materialButton3.TabIndex = 6;
            this.materialButton3.Text = "Редактировать";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(513, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Темы";
            // 
            // grThemes
            // 
            this.grThemes.AllowUserToResizeRows = false;
            this.grThemes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grThemes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grThemes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grThemes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grThemes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grThemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grThemes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grThemes.DefaultCellStyle = dataGridViewCellStyle6;
            this.grThemes.EnableHeadersVisualStyles = false;
            this.grThemes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grThemes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grThemes.Location = new System.Drawing.Point(519, 113);
            this.grThemes.Name = "grThemes";
            this.grThemes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grThemes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grThemes.RowHeadersVisible = false;
            this.grThemes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            this.grThemes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grThemes.RowTemplate.Height = 50;
            this.grThemes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grThemes.Size = new System.Drawing.Size(364, 276);
            this.grThemes.TabIndex = 8;
            this.grThemes.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cbAllThemes
            // 
            this.cbAllThemes.AutoResize = false;
            this.cbAllThemes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbAllThemes.Depth = 0;
            this.cbAllThemes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbAllThemes.DropDownHeight = 118;
            this.cbAllThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAllThemes.DropDownWidth = 121;
            this.cbAllThemes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbAllThemes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbAllThemes.FormattingEnabled = true;
            this.cbAllThemes.Hint = "Темы";
            this.cbAllThemes.IntegralHeight = false;
            this.cbAllThemes.ItemHeight = 29;
            this.cbAllThemes.Location = new System.Drawing.Point(519, 396);
            this.cbAllThemes.MaxDropDownItems = 4;
            this.cbAllThemes.MouseState = MaterialSkin.MouseState.OUT;
            this.cbAllThemes.Name = "cbAllThemes";
            this.cbAllThemes.Size = new System.Drawing.Size(364, 35);
            this.cbAllThemes.TabIndex = 9;
            this.cbAllThemes.UseTallSize = false;
            // 
            // btLinkTheme
            // 
            this.btLinkTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLinkTheme.Depth = 0;
            this.btLinkTheme.DrawShadows = true;
            this.btLinkTheme.HighEmphasis = true;
            this.btLinkTheme.Icon = null;
            this.btLinkTheme.Location = new System.Drawing.Point(519, 440);
            this.btLinkTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btLinkTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btLinkTheme.Name = "btLinkTheme";
            this.btLinkTheme.Size = new System.Drawing.Size(86, 36);
            this.btLinkTheme.TabIndex = 10;
            this.btLinkTheme.Text = "Связать";
            this.btLinkTheme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btLinkTheme.UseAccentColor = false;
            this.btLinkTheme.UseVisualStyleBackColor = true;
            this.btLinkTheme.Click += new System.EventHandler(this.btLinkTheme_Click);
            // 
            // btDeleteLinkedTheme
            // 
            this.btDeleteLinkedTheme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDeleteLinkedTheme.Depth = 0;
            this.btDeleteLinkedTheme.DrawShadows = true;
            this.btDeleteLinkedTheme.HighEmphasis = true;
            this.btDeleteLinkedTheme.Icon = null;
            this.btDeleteLinkedTheme.Location = new System.Drawing.Point(792, 440);
            this.btDeleteLinkedTheme.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btDeleteLinkedTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDeleteLinkedTheme.Name = "btDeleteLinkedTheme";
            this.btDeleteLinkedTheme.Size = new System.Drawing.Size(91, 36);
            this.btDeleteLinkedTheme.TabIndex = 11;
            this.btDeleteLinkedTheme.Text = "Удалить";
            this.btDeleteLinkedTheme.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btDeleteLinkedTheme.UseAccentColor = true;
            this.btDeleteLinkedTheme.UseVisualStyleBackColor = true;
            this.btDeleteLinkedTheme.Click += new System.EventHandler(this.btDeleteLinkedTheme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вопросы";
            // 
            // grSubject
            // 
            this.grSubject.AutoResize = false;
            this.grSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grSubject.Depth = 0;
            this.grSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.grSubject.DropDownHeight = 118;
            this.grSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grSubject.DropDownWidth = 121;
            this.grSubject.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.grSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grSubject.FormattingEnabled = true;
            this.grSubject.Hint = "Предмет";
            this.grSubject.IntegralHeight = false;
            this.grSubject.ItemHeight = 29;
            this.grSubject.Location = new System.Drawing.Point(233, 27);
            this.grSubject.MaxDropDownItems = 4;
            this.grSubject.MouseState = MaterialSkin.MouseState.OUT;
            this.grSubject.Name = "grSubject";
            this.grSubject.Size = new System.Drawing.Size(295, 35);
            this.grSubject.TabIndex = 12;
            this.grSubject.UseTallSize = false;
            this.grSubject.SelectedIndexChanged += new System.EventHandler(this.grSubject_SelectedIndexChanged);
            // 
            // btSaveSubject
            // 
            this.btSaveSubject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSaveSubject.Depth = 0;
            this.btSaveSubject.DrawShadows = true;
            this.btSaveSubject.HighEmphasis = true;
            this.btSaveSubject.Icon = null;
            this.btSaveSubject.Location = new System.Drawing.Point(535, 26);
            this.btSaveSubject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSaveSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSaveSubject.Name = "btSaveSubject";
            this.btSaveSubject.Size = new System.Drawing.Size(182, 36);
            this.btSaveSubject.TabIndex = 13;
            this.btSaveSubject.Text = "Сохранить предмет";
            this.btSaveSubject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btSaveSubject.UseAccentColor = false;
            this.btSaveSubject.UseVisualStyleBackColor = true;
            this.btSaveSubject.Click += new System.EventHandler(this.btSaveSubject_Click);
            // 
            // TestEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 487);
            this.Controls.Add(this.btSaveSubject);
            this.Controls.Add(this.grSubject);
            this.Controls.Add(this.btDeleteLinkedTheme);
            this.Controls.Add(this.btLinkTheme);
            this.Controls.Add(this.cbAllThemes);
            this.Controls.Add(this.grThemes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grQuestions);
            this.Name = "TestEditor";
            this.Padding = new System.Windows.Forms.Padding(10, 110, 10, 50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestEditor";
            ((System.ComponentModel.ISupportInitialize)(this.grQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThemes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grQuestions;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btDelete;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroGrid grThemes;
        private MaterialSkin.Controls.MaterialComboBox cbAllThemes;
        private MaterialSkin.Controls.MaterialButton btLinkTheme;
        private MaterialSkin.Controls.MaterialButton btDeleteLinkedTheme;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox grSubject;
        private MaterialSkin.Controls.MaterialButton btSaveSubject;
    }
}