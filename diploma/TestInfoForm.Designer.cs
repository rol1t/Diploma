namespace diploma
{
    partial class TestInfoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btStartTest = new MaterialSkin.Controls.MaterialButton();
            this.grQuestions = new MetroFramework.Controls.MetroGrid();
            this.txtDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // btStartTest
            // 
            this.btStartTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btStartTest.Depth = 0;
            this.btStartTest.DrawShadows = true;
            this.btStartTest.HighEmphasis = true;
            this.btStartTest.Icon = null;
            this.btStartTest.Location = new System.Drawing.Point(436, 563);
            this.btStartTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btStartTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btStartTest.Name = "btStartTest";
            this.btStartTest.Size = new System.Drawing.Size(121, 36);
            this.btStartTest.TabIndex = 0;
            this.btStartTest.Text = "Пройти тест";
            this.btStartTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btStartTest.UseAccentColor = false;
            this.btStartTest.UseVisualStyleBackColor = true;
            this.btStartTest.Click += new System.EventHandler(this.btStartTest_Click);
            // 
            // grQuestions
            // 
            this.grQuestions.AllowUserToResizeRows = false;
            this.grQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grQuestions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grQuestions.DefaultCellStyle = dataGridViewCellStyle10;
            this.grQuestions.EnableHeadersVisualStyles = false;
            this.grQuestions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grQuestions.Location = new System.Drawing.Point(12, 309);
            this.grQuestions.Name = "grQuestions";
            this.grQuestions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grQuestions.RowHeadersVisible = false;
            this.grQuestions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            this.grQuestions.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.grQuestions.RowTemplate.Height = 50;
            this.grQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grQuestions.Size = new System.Drawing.Size(545, 200);
            this.grQuestions.TabIndex = 9;
            this.grQuestions.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Depth = 0;
            this.txtDescription.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescription.Hint = "";
            this.txtDescription.Location = new System.Drawing.Point(12, 68);
            this.txtDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(545, 235);
            this.txtDescription.TabIndex = 10;
            this.txtDescription.Text = "";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTime.Location = new System.Drawing.Point(6, 512);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(225, 33);
            this.txtTime.TabIndex = 11;
            this.txtTime.Text = "Времени на тест";
            this.txtTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // TestInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 602);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.grQuestions);
            this.Controls.Add(this.btStartTest);
            this.Name = "TestInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.grQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btStartTest;
        private MetroFramework.Controls.MetroGrid grQuestions;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtDescription;
        private System.Windows.Forms.Label txtTime;
    }
}