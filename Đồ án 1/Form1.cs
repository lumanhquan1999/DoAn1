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
            try
            {
                myList.clear(myList); //Xóa hết dữ liệu đã tồn tại trong danh sách liên kết
                StreamReader rd = new StreamReader("Sach.txt", Encoding.UTF8); //Đọc file text
                if (rd == null) MessageBox.Show("Đọc file không thành công.", "THÔNG BÁO:");
                string x = rd.ReadLine();
                sosach = Convert.ToInt32(x);
                for (int i = 0; i < sosach; i++)
                {
                    string x1 = rd.ReadLine();
                    dsChuoi.Add(x1);
                }
                for (int j = 0; j < sosach; j++)
                {
                    SACH x2 = new SACH();
                    string thongtin = dsChuoi[j];
                    string[] masach = thongtin.Split('*', '+');
                    string[] tensach = thongtin.Split('+', '-');
                    string[] loaisach = thongtin.Split('-', '<');
                    string[] dongia = thongtin.Split('<', '>');
                    x2.Nhap(Convert.ToString(masach[1]), Convert.ToString(tensach[1]), Convert.ToString(loaisach[1]), Convert.ToString(dongia[1]));
                    myList.addHead(x2);

                }
                myList.Sort();
                if (rd != null) MessageBox.Show("Lấy dữ liệu thành công.", "THÔNG BÁO:");
                rd.Close();
            }
            catch { }
        }

        private void DanhSach_Click(object sender, EventArgs e)
        {
           try
            {
                Node xuat1 = myList.Head;
                int m = 1;
                string ap = "";

                while (xuat1 != null)
                {
                    string masach = xuat1.info.MaSach;
                    string tensach = xuat1.info.TenSach;
                    string loaisach = xuat1.info.LoaiSach;
                    string dongia = xuat1.info.DonGia;

                    xuat1 = xuat1.Next;

                    ap += masach + "                ";
                   
                    ap += tensach + "                       ";
                    
                    ap += loaisach + "              ";
                    
                    ap += dongia + Environment.NewLine;
                    
                }
                textBox1.Text = ap;
                if (myList.Head == null) MessageBox.Show("Danh sách nhân viên đang rỗng. \nHãy LẤY DỮ LIỆU hoặc THÊM", "THÔNG BÁO:");
                else MessageBox.Show("Xuất thành công.", "THÔNG BÁO:");
            }
            catch { }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            ThemSach them = new ThemSach();
            them.ShowDialog();
            Node p = new Node();
            SACH Sthem = new SACH();
            Sthem = them.temp;
            p = myList.Head;
            int kt = 0;
            if (them.ktThem == 1)
                MessageBox.Show("Thông tin thêm vào không hợp lệ hoặc đang trống.", "THÔNG BÁO:");
            else
            {
                while (p != null)
                {
                    if (them.temp.MaSach == p.info.MaSach)
                    {
                        kt = 1; //Nếu MaSach bị trùng thì thay đổi biến kt để không thêm vào danh sách liên kết.  
                        MessageBox.Show("Đã có trong danh sách");
                    }
                    p = p.Next;
                }
                if (kt == 0 && them.temp.MaSach != null)
                {

                    myList.addHead(them.temp);
                    //myList.Sort();
                    MessageBox.Show("Thêm sách thành công.", "THÔNG BÁO:");
                }
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            XoaSach xoa = new XoaSach();
            xoa.ShowDialog();
            int kt = 0;
            Node p = new Node();
            p = myList.Head;
            while (p != null)
            {
                if (xoa.Sxoa == p.info.MaSach)
                {
                    kt = 1;
                }
                p = p.Next;
            }
            if (kt == 1)
            {
                myList.removeKey(myList, xoa.Sxoa);
                MessageBox.Show("Xóa thành công.", "THÔNG BÁO:");
            }
            else MessageBox.Show("Xóa không thành công. \nSách muốn xóa không tồn tại hoặc bạn chưa nhập MaSach cần xóa", "THÔNG BÁO:");
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> dsDong = new List<string>();
                FileStream fs = new FileStream("Sach.txt", FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sosach = myList.CountNode(myList);
                sWriter.WriteLine(sosach);
                Node temp = new Node();
                temp = myList.Head;
                while (temp != null)
                {
                    string dong = "*" + temp.info.MaSach + "+" + temp.info.TenSach + "-" + temp.info.LoaiSach + "<" + temp.info.DonGia;
                    dsDong.Add(dong);
                    temp = temp.Next;
                }
                for (int i = 0; i < dsDong.Count; i++)
                {
                    sWriter.WriteLine(dsDong[i]);
                }
                sWriter.Flush();
                fs.Close();
                MessageBox.Show("Lưu thành công.", "THÔNG BÁO:");
            }
            catch { }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            SuaSach sua = new SuaSach();
            sua.ShowDialog();
            int kt = 0;
            Node Sthaydoi = new Node();
            Sthaydoi = myList.Head;
            while (Sthaydoi != null)
            {
                if (Sthaydoi.info.MaSach == sua.masach)
                {
                    Sthaydoi.info = sua.Std;
                    kt = 1;
                }
                Sthaydoi = Sthaydoi.Next;
            }
            if (kt == 1) MessageBox.Show("Thay đổi thông tin sách thành công.", "THÔNG BÁO:");
            else MessageBox.Show("Không tồn tại sách cần thay đổi thông tin", "THÔNG BÁO:");
        }
    }
}
