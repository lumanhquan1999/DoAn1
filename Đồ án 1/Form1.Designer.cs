namespace Đồ_án_1
{
    partial class Tim
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
            this.label1 = new System.Windows.Forms.Label();
            this.Them = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Doc = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DanhSach = new System.Windows.Forms.Button();
            this.Tang = new System.Windows.Forms.Button();
            this.Giam = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tTimKiem = new System.Windows.Forms.TextBox();
            this.btnPrintbooks = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(1015, 69);
            this.Them.Margin = new System.Windows.Forms.Padding(4);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(104, 46);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm trước";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(1016, 132);
            this.Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(103, 38);
            this.Xoa.TabIndex = 2;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(1016, 188);
            this.Sua.Margin = new System.Windows.Forms.Padding(4);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(103, 39);
            this.Sua.TabIndex = 3;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Doc
            // 
            this.Doc.Location = new System.Drawing.Point(1016, 245);
            this.Doc.Margin = new System.Windows.Forms.Padding(4);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(103, 40);
            this.Doc.TabIndex = 4;
            this.Doc.Text = "Đọc";
            this.Doc.UseVisualStyleBackColor = true;
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(1174, 307);
            this.Luu.Margin = new System.Windows.Forms.Padding(4);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(102, 48);
            this.Luu.TabIndex = 6;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(956, 297);
            this.textBox1.TabIndex = 7;
            // 
            // DanhSach
            // 
            this.DanhSach.Location = new System.Drawing.Point(1174, 132);
            this.DanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.DanhSach.Name = "DanhSach";
            this.DanhSach.Size = new System.Drawing.Size(102, 38);
            this.DanhSach.TabIndex = 8;
            this.DanhSach.Text = "Xuất dữ liệu";
            this.DanhSach.UseVisualStyleBackColor = true;
            this.DanhSach.Click += new System.EventHandler(this.DanhSach_Click);
            // 
            // Tang
            // 
            this.Tang.Location = new System.Drawing.Point(1174, 188);
            this.Tang.Margin = new System.Windows.Forms.Padding(4);
            this.Tang.Name = "Tang";
            this.Tang.Size = new System.Drawing.Size(102, 39);
            this.Tang.TabIndex = 9;
            this.Tang.Text = "Tăng";
            this.Tang.UseVisualStyleBackColor = true;
            this.Tang.Click += new System.EventHandler(this.Tang_Click);
            // 
            // Giam
            // 
            this.Giam.Location = new System.Drawing.Point(1174, 245);
            this.Giam.Margin = new System.Windows.Forms.Padding(4);
            this.Giam.Name = "Giam";
            this.Giam.Size = new System.Drawing.Size(102, 37);
            this.Giam.TabIndex = 10;
            this.Giam.Text = "Giảm";
            this.Giam.UseVisualStyleBackColor = true;
            this.Giam.Click += new System.EventHandler(this.Giam_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tTimKiem
            // 
            this.tTimKiem.Location = new System.Drawing.Point(232, 417);
            this.tTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.tTimKiem.Name = "tTimKiem";
            this.tTimKiem.Size = new System.Drawing.Size(697, 22);
            this.tTimKiem.TabIndex = 12;
            // 
            // btnPrintbooks
            // 
            this.btnPrintbooks.Location = new System.Drawing.Point(1016, 377);
            this.btnPrintbooks.Name = "btnPrintbooks";
            this.btnPrintbooks.Size = new System.Drawing.Size(103, 73);
            this.btnPrintbooks.TabIndex = 13;
            this.btnPrintbooks.Text = "In tất cả sách theo loại sách";
            this.btnPrintbooks.UseVisualStyleBackColor = true;
            this.btnPrintbooks.Click += new System.EventHandler(this.btnPrintbooks_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1016, 307);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 48);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1174, 69);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 46);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm sau";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Tim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 554);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrintbooks);
            this.Controls.Add(this.tTimKiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Giam);
            this.Controls.Add(this.Tang);
            this.Controls.Add(this.DanhSach);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tim";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Doc;
        private System.Windows.Forms.Button Luu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DanhSach;
        private System.Windows.Forms.Button Tang;
        private System.Windows.Forms.Button Giam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tTimKiem;
        private System.Windows.Forms.Button btnPrintbooks;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThem;
    }
}

