namespace diploma
{
    partial class TestStatForm
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
            this.btPrint = new MaterialSkin.Controls.MaterialButton();
            this.txtCount = new System.Windows.Forms.Label();
            this.txtAvgProcent = new System.Windows.Forms.Label();
            this.grResults = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btPrint
            // 
            this.btPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btPrint.Depth = 0;
            this.btPrint.DrawShadows = false;
            this.btPrint.HighEmphasis = true;
            this.btPrint.Icon = null;
            this.btPrint.Location = new System.Drawing.Point(357, 25);
            this.btPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(78, 36);
            this.btPrint.TabIndex = 0;
            this.btPrint.Text = "Печать";
            this.btPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btPrint.UseAccentColor = false;
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCount.Location = new System.Drawing.Point(4, 67);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(359, 33);
            this.txtCount.TabIndex = 6;
            this.txtCount.Text = "Количество прохождений: ";
            // 
            // txtAvgProcent
            // 
            this.txtAvgProcent.AutoSize = true;
            this.txtAvgProcent.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAvgProcent.Location = new System.Drawing.Point(4, 100);
            this.txtAvgProcent.Name = "txtAvgProcent";
            this.txtAvgProcent.Size = new System.Drawing.Size(431, 33);
            this.txtAvgProcent.TabIndex = 7;
            this.txtAvgProcent.Text = "Средний процент прохождения: ";
            // 
            // grResults
            // 
            this.grResults.AllowUserToResizeRows = false;
            this.grResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grResults.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.grResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grResults.EnableHeadersVisualStyles = false;
            this.grResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grResults.Location = new System.Drawing.Point(10, 150);
            this.grResults.Name = "grResults";
            this.grResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grResults.RowHeadersVisible = false;
            this.grResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            this.grResults.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grResults.RowTemplate.Height = 50;
            this.grResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grResults.Size = new System.Drawing.Size(764, 375);
            this.grResults.TabIndex = 8;
            this.grResults.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // TestStatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.grResults);
            this.Controls.Add(this.txtAvgProcent);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btPrint);
            this.Name = "TestStatForm";
            this.Padding = new System.Windows.Forms.Padding(10, 150, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestStatForm";
            ((System.ComponentModel.ISupportInitialize)(this.grResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btPrint;
        private System.Windows.Forms.Label txtCount;
        private System.Windows.Forms.Label txtAvgProcent;
        private MetroFramework.Controls.MetroGrid grResults;
    }
}