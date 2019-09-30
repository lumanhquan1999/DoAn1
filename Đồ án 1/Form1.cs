using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace Đồ_án_1
{
    public partial class Form1 : Form
    {
        LinkedList myList = new LinkedList();
        List<string> dsChuoi = new List<string>();
        public int sosach;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Doc_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("QuanLySach.txt", Encoding.UTF8);
            reader.Close();
        }
    }
}
