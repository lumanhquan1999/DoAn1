namespace Đồ_án_1
{
    partial class Form2
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
            this.Them = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Doc = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.Xuat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(927, 318);
            this.textBox1.TabIndex = 0;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(12, 356);
            this.Them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(104, 37);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm trước";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(165, 357);
            this.Xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(119, 34);
            this.Xoa.TabIndex = 2;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(341, 354);
            this.Sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(107, 37);
            this.Sua.TabIndex = 3;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Doc
            // 
            this.Doc.Location = new System.Drawing.Point(496, 356);
            this.Doc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(111, 34);
            this.Doc.TabIndex = 4;
            this.Doc.Text = "Đọc";
            this.Doc.UseVisualStyleBackColor = true;
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(657, 358);
            this.Luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(115, 33);
            this.Luu.TabIndex = 5;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // Xuat
            // 
            this.Xuat.Location = new System.Drawing.Point(820, 359);
            this.Xuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Xuat.Name = "Xuat";
            this.Xuat.Size = new System.Drawing.Size(107, 32);
            this.Xuat.TabIndex = 6;
            this.Xuat.Text = "Xuất";
            this.Xuat.UseVisualStyleBackColor = true;
            this.Xuat.Click += new System.EventHandler(this.Xuat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 400);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 41);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm sau";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.Xuat);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.Button Xuat;
        private System.Windows.Forms.Button btnThem;
    }
}