namespace diploma
{
    partial class ThemeReader
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btPrint = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(10, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(851, 499);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btPrint
            // 
            this.btPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btPrint.Depth = 0;
            this.btPrint.DrawShadows = true;
            this.btPrint.HighEmphasis = true;
            this.btPrint.Icon = null;
            this.btPrint.Location = new System.Drawing.Point(761, 25);
            this.btPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(100, 36);
            this.btPrint.TabIndex = 5;
            this.btPrint.Text = "Печать";
            this.btPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btPrint.UseAccentColor = false;
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // ThemeReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(871, 579);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ThemeReader";
            this.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemeReader";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThemeReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialButton btPrint;
    }
}