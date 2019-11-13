namespace Đồ_án_1
{
    partial class ThemLoaiSach
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
            this.button1 = new System.Windows.Forms.Button();
            this.tLoaiSach = new System.Windows.Forms.TextBox();
            this.tTacGia = new System.Windows.Forms.TextBox();
            this.tNXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tLoaiSach
            // 
            this.tLoaiSach.Location = new System.Drawing.Point(331, 55);
            this.tLoaiSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tLoaiSach.Name = "tLoaiSach";
            this.tLoaiSach.Size = new System.Drawing.Size(249, 22);
            this.tLoaiSach.TabIndex = 1;
            // 
            // tTacGia
            // 
            this.tTacGia.Location = new System.Drawing.Point(331, 116);
            this.tTacGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tTacGia.Name = "tTacGia";
            this.tTacGia.Size = new System.Drawing.Size(248, 22);
            this.tTacGia.TabIndex = 2;
            // 
            // tNXB
            // 
            this.tNXB.Location = new System.Drawing.Point(331, 187);
            this.tNXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tNXB.Name = "tNXB";
            this.tNXB.Size = new System.Drawing.Size(249, 22);
            this.tNXB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thế Loại Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhà Xuất Bản";
            // 
            // ThemLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNXB);
            this.Controls.Add(this.tTacGia);
            this.Controls.Add(this.tLoaiSach);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThemLoaiSach";
            this.Text = "ThemLoaiSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tLoaiSach;
        private System.Windows.Forms.TextBox tTacGia;
        private System.Windows.Forms.TextBox tNXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}