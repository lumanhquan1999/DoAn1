namespace Đồ_án_1
{
    partial class ThemSach
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
            this.tMaSach = new System.Windows.Forms.TextBox();
            this.tTenSach = new System.Windows.Forms.TextBox();
            this.tLoaiSach = new System.Windows.Forms.TextBox();
            this.tDonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tMaSach
            // 
            this.tMaSach.Location = new System.Drawing.Point(133, 57);
            this.tMaSach.Name = "tMaSach";
            this.tMaSach.Size = new System.Drawing.Size(116, 20);
            this.tMaSach.TabIndex = 1;
            // 
            // tTenSach
            // 
            this.tTenSach.Location = new System.Drawing.Point(132, 108);
            this.tTenSach.Name = "tTenSach";
            this.tTenSach.Size = new System.Drawing.Size(116, 20);
            this.tTenSach.TabIndex = 2;
            // 
            // tLoaiSach
            // 
            this.tLoaiSach.Location = new System.Drawing.Point(134, 165);
            this.tLoaiSach.Name = "tLoaiSach";
            this.tLoaiSach.Size = new System.Drawing.Size(114, 20);
            this.tLoaiSach.TabIndex = 3;
            // 
            // tDonGia
            // 
            this.tDonGia.Location = new System.Drawing.Point(134, 220);
            this.tDonGia.Name = "tDonGia";
            this.tDonGia.Size = new System.Drawing.Size(114, 20);
            this.tDonGia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại Sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn Giá";
            // 
            // ThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tDonGia);
            this.Controls.Add(this.tLoaiSach);
            this.Controls.Add(this.tTenSach);
            this.Controls.Add(this.tMaSach);
            this.Controls.Add(this.button1);
            this.Name = "ThemSach";
            this.Text = "ThemSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tMaSach;
        private System.Windows.Forms.TextBox tTenSach;
        private System.Windows.Forms.TextBox tLoaiSach;
        private System.Windows.Forms.TextBox tDonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
