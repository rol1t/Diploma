namespace diploma
{
    partial class ResultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtResultText = new System.Windows.Forms.Label();
            this.grRanking = new MetroFramework.Controls.MetroGrid();
            this.btCloseResult = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.grRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResultText
            // 
            this.txtResultText.AutoSize = true;
            this.txtResultText.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResultText.Location = new System.Drawing.Point(14, 66);
            this.txtResultText.Name = "txtResultText";
            this.txtResultText.Size = new System.Drawing.Size(157, 33);
            this.txtResultText.TabIndex = 5;
            this.txtResultText.Text = "Результат: ";
            // 
            // grRanking
            // 
            this.grRanking.AllowUserToResizeRows = false;
            this.grRanking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grRanking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grRanking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grRanking.DefaultCellStyle = dataGridViewCellStyle6;
            this.grRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grRanking.EnableHeadersVisualStyles = false;
            this.grRanking.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grRanking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grRanking.Location = new System.Drawing.Point(20, 150);
            this.grRanking.Name = "grRanking";
            this.grRanking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grRanking.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grRanking.RowHeadersVisible = false;
            this.grRanking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            this.grRanking.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grRanking.RowTemplate.Height = 50;
            this.grRanking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grRanking.Size = new System.Drawing.Size(402, 357);
            this.grRanking.TabIndex = 6;
            this.grRanking.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btCloseResult
            // 
            this.btCloseResult.AutoSize = false;
            this.btCloseResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCloseResult.Depth = 0;
            this.btCloseResult.DrawShadows = true;
            this.btCloseResult.HighEmphasis = true;
            this.btCloseResult.Icon = null;
            this.btCloseResult.Location = new System.Drawing.Point(20, 105);
            this.btCloseResult.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btCloseResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCloseResult.Name = "btCloseResult";
            this.btCloseResult.Size = new System.Drawing.Size(109, 36);
            this.btCloseResult.TabIndex = 7;
            this.btCloseResult.Text = "Выйти";
            this.btCloseResult.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btCloseResult.UseAccentColor = false;
            this.btCloseResult.UseVisualStyleBackColor = true;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 527);
            this.Controls.Add(this.btCloseResult);
            this.Controls.Add(this.grRanking);
            this.Controls.Add(this.txtResultText);
            this.Name = "ResultForm";
            this.Padding = new System.Windows.Forms.Padding(20, 150, 20, 20);
            this.Text = "Результат";
            ((System.ComponentModel.ISupportInitialize)(this.grRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtResultText;
        private MetroFramework.Controls.MetroGrid grRanking;
        private MaterialSkin.Controls.MaterialButton btCloseResult;
    }
}