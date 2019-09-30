namespace Đồ_án_1
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SÁCH";
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(532, 58);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(78, 37);
            this.Them.TabIndex = 1;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(531, 123);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(77, 40);
            this.Xoa.TabIndex = 2;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            // 
            // Sua
            // 
            this.Sua.Location = new System.Drawing.Point(533, 187);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(76, 34);
            this.Sua.TabIndex = 3;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = true;
            // 
            // Doc
            // 
            this.Doc.Location = new System.Drawing.Point(536, 240);
            this.Doc.Name = "Doc";
            this.Doc.Size = new System.Drawing.Size(74, 39);
            this.Doc.TabIndex = 4;
            this.Doc.Text = "Đọc";
            this.Doc.UseVisualStyleBackColor = true;
            this.Doc.Click += new System.EventHandler(this.Doc_Click);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(536, 305);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(74, 38);
            this.Luu.TabIndex = 6;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(403, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.Doc);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
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
    }
}

