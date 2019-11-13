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
    public partial class SuaLoaiSach : Form
    {
        public string loaisach, tacgia, nxb;        
        public SACH Ltd = new SACH();

        private void button1_Click_1(object sender, EventArgs e)
        {
            loaisach = tLoaiSach.Text;
            tacgia = tTacGia.Text;
            nxb = tNXB.Text;

            Ltd.Nhap2(loaisach, tacgia, nxb);
            this.Close();
        }

        public SuaLoaiSach()
        {
            InitializeComponent();
        }
       
    }
}
