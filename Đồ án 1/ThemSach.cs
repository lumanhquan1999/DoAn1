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
    public partial class ThemSach : Form
    {
        public SACH temp = new SACH();
        public int ktThem = 0;
        public ThemSach()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (tMaSach.Text.CompareTo("") == 0) ktThem = 1;
            else
                temp.Nhap(tMaSach.Text, tTenSach.Text, tLoaiSach.Text, Convert.ToInt32(tDonGia.Text));
            this.Close();
        }
    }
}
