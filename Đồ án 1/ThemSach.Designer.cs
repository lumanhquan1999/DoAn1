﻿namespace Đồ_án_1
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
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
            // ThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}