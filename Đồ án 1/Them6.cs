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
    public partial class Them6 : Form
    {
        public SACH temp = new SACH();
        public int ktThem = 0;
        public Them6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tMaSach.Text.CompareTo("") == 0) ktThem = 1;
            else
                temp.Nhap6(tMaSach.Text, tTenSach.Text, tLoaiSach.Text, Convert.ToInt32(tDonGia.Text), tNgayMua.Text, Convert.ToInt32(tSoLuongMua.Text));
            this.Close();
        }
    }
}
