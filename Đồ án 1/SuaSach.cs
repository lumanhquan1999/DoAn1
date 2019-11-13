using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_1
{
    public partial class SuaSach : Form
    {
        public string masach, tensach, loaisach;
        public int dongia;
        public SACH Std = new SACH();
        public SuaSach()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            masach = textBox1.Text;
            tensach = textBox2.Text;
            loaisach = textBox3.Text;
            dongia = Convert.ToInt32(textBox4.Text);
            
            Std.Nhap(masach, tensach, loaisach, dongia);
            this.Close();
        }
    }
}
