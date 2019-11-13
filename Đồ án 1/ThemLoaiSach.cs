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
    public partial class ThemLoaiSach : Form
    {
        public SACH temp = new SACH();
        public int ktThem = 0;
        public ThemLoaiSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tLoaiSach.Text.CompareTo("") == 0) ktThem = 1;
            else
                temp.Nhap2(tLoaiSach.Text, tTacGia.Text, tNXB.Text);
            this.Close();
        }
    }
}
