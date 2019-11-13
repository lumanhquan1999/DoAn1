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
using System.Text.RegularExpressions; //Để dùng hàm Regex và Match
using System.Threading;


namespace Đồ_án_1
{
    public partial class Tim : Form
    {
        LinkedList myList = new LinkedList();
        List<string> dsChuoi = new List<string>();
        public int sosach;
        public Tim()
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
                string x = rd.ReadLine();           /// doc so cuon sach              
                sosach = Convert.ToInt32(x);        ///                 
                for (int i = 0; i < sosach; i++)
                {
                    string x1 = rd.ReadLine();
                    dsChuoi.Add(x1);
                }
                for (int j = 0; j < sosach; j++)
                {
                    SACH x2 = new SACH();
                    string[] thongtin = dsChuoi[j].Split('/');
                    x2.Nhap(thongtin[1], thongtin[2], thongtin[3], int.Parse(thongtin[4]));
                    myList.addHead(x2);

                }

                if (rd != null) MessageBox.Show("Lấy dữ liệu thành công.", "THÔNG BÁO:");
                rd.Close();
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void DanhSach_Click(object sender, EventArgs e)
        {
            try
            {
                Node xuat1 = myList.Head;
                string ap = "";
                while (xuat1 != null)
                {
                    string masach = xuat1.info.MaSach;
                    string tensach = xuat1.info.TenSach;
                    string loaisach = xuat1.info.LoaiSach;
                    float dongia = xuat1.info.DonGia;
                    xuat1 = xuat1.Next;
                    ap += "MaSach: " + masach + "        ";
                    ap += "TenSach: " + tensach + "               ";
                    ap += "LoaiSach: " + loaisach + "  ";
                    ap += "DonGia: " + dongia + Environment.NewLine;
                    //ap += string.Format("{0,-6} {1,-40} {2,-10} {3,-7}", masach, tensach, loaisach, dongia)+ Environment.NewLine;

                }
                textBox1.Text = ap;
                if (myList.Head == null) MessageBox.Show("Danh sách sách đang rỗng. \nHãy LẤY DỮ LIỆU hoặc THÊM", "THÔNG BÁO:");
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
                FileStream fs = new FileStream("Sach.txt", FileMode.OpenOrCreate);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sosach = myList.CountNode(myList);
                sWriter.WriteLine(sosach);
                //sWriter.WriteLine("MaSach/TenSach/LoaiSach/DonGia/NgayMua/SoLuongMua/TongTien/GiamGia/ThanhTien");
                Node temp = new Node();
                temp = myList.Head;
                while (temp != null)
                {
                    string dong = "/" + temp.info.MaSach + "/" + temp.info.TenSach + "/" + temp.info.LoaiSach + "/" + temp.info.DonGia;
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
            catch (Exception ee) { MessageBox.Show(ee.ToString()); }
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

        private void Tang_Click(object sender, EventArgs e)
        {
            myList.Sort();
            string Textview = textBox1.Text;
            System.IO.File.WriteAllText("8res.txt", Textview);
        }

        private void Giam_Click(object sender, EventArgs e)
        {
            myList.Sort1();
            string Textview = textBox1.Text;
            System.IO.File.WriteAllText("8res.txt", Textview);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = null;
            string ap = "";
            if (tTimKiem.Text != null)
            {
                x = tTimKiem.Text;
            }
            else MessageBox.Show("Ô tìm kiếm đang trống. \n Hãy nhập thông tin cần tìm.", "THÔNG BÁO:");
            myList.SearchNode(myList, x);
            Node xuat1 = myList.Head;
            for (int i = 0; i < myList.found.Count; i++)
            {
                string masach = myList.found[i].MaSach;
                string loaisach = myList.found[i].LoaiSach;
                string tensach = myList.found[i].TenSach;
                float dongia = myList.found[i].DonGia;
                ap += masach + "                               ";
                ap += tensach + "                                              ";
                ap += loaisach + "                                              ";
                ap += dongia + Environment.NewLine;
            }
            textBox1.Text = ap;
            if (myList.found.Count == 0) MessageBox.Show("Không có thông tin tương thích.", "THÔNG BÁO:");
            myList.found.Clear();
        }
        private void btnPrintbooks_Click(object sender, EventArgs e)
        {
            if (File.Exists("Sach.txt"))
            {
                string[] words = File.ReadAllLines("Sach.txt");
                int count = 0;
                string ap = "";
                if (tTimKiem.Text == "")
                {
                    textBox1.Clear();
                    MessageBox.Show("Chưa thể tìm nếu không có thông tin về loại sách.", "THÔNG BÁO:");
                }
                else {
                    foreach (string line in words)
                    {
                        if (line.StartsWith("/" + tTimKiem.Text))
                        {
                            /*
                            textBox1.AppendText(line);
                            textBox1.AppendText(Environment.NewLine);*/
                            ap += line;
                            ap += Environment.NewLine;
                            count += 1;
                        }
                    }
                    ap += Environment.NewLine;
                    ap += "Tổng số sách thuộc loại sách " + tTimKiem.Text + " là : " + count.ToString() + ". " + Environment.NewLine;
                }               
                textBox1.Text = ap;
            }
            /*
            else
            {
                MessageBox.Show("Tra không thành công. \nLoại sách không có sẵn hoặc chưa có sách nào luộc loại sách trên", "THÔNG BÁO:");
            }*/
            string Textview = textBox1.Text;
            System.IO.File.WriteAllText("9res.txt", Textview);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void btnThem_Click(object sender, EventArgs e)
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

                    myList.addTail(them.temp);
                    MessageBox.Show("Thêm sách thành công.", "THÔNG BÁO:");
                }
            }
        }
    }
}
