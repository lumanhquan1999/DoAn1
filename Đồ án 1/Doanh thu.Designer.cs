namespace Đồ_án_1
{
    partial class Doanh_thu
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
            this.Luu = new System.Windows.Forms.Button();
            this.Xuat = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1435, 330);
            this.textBox1.TabIndex = 0;
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(773, 373);
            this.Luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(131, 42);
            this.Luu.TabIndex = 2;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // Xuat
            // 
            this.Xuat.Location = new System.Drawing.Point(471, 373);
            this.Xuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Xuat.Name = "Xuat";
            this.Xuat.Size = new System.Drawing.Size(137, 42);
            this.Xuat.TabIndex = 3;
            this.Xuat.Text = "Xuất";
            this.Xuat.UseVisualStyleBackColor = true;
            this.Xuat.Click += new System.EventHandler(this.Xuat_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(471, 441);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(433, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập mã sách để xem doanh thu :";
            // 
            // Doanh_thu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Xuat);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Doanh_thu";
            this.Text = "Doanh_thu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.Button Xuat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}