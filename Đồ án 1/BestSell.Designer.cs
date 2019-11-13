namespace Đồ_án_1
{
    partial class BestSell
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Xuất = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1300, 211);
            this.textBox1.TabIndex = 0;
            // 
            // Xuất
            // 
            this.Xuất.Location = new System.Drawing.Point(405, 286);
            this.Xuất.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Xuất.Name = "Xuất";
            this.Xuất.Size = new System.Drawing.Size(147, 44);
            this.Xuất.TabIndex = 2;
            this.Xuất.Text = "Xuất";
            this.Xuất.UseVisualStyleBackColor = true;
            this.Xuất.Click += new System.EventHandler(this.Xuất_Click);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(785, 286);
            this.Luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(145, 44);
            this.Luu.TabIndex = 3;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // BestSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 554);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.Xuất);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BestSell";
            this.Text = "BestSell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Xuất;
        private System.Windows.Forms.Button Luu;
    }
}