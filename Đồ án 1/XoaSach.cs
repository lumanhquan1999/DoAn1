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
    public partial class XoaSach : Form
    {
        public string Sxoa;        
        public XoaSach()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Sxoa = tMaSach.Text;           
            this.Close();
        }
    }
}
