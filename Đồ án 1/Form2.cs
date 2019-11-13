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

namespace Đồ_án_1
{
    public partial class Form2 : Form
    {
        LinkedList myList = new LinkedList();
        List<string> dsChuoi = new List<string>();
        public int soloaisach;
        public Form2()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            ThemLoaiSach them = new ThemLoaiSach();
            them.ShowDialog();
            Node a = new Node();
            SACH Lthem = new SACH();
            Lthem = them.temp;
            a = myList.Head;
            int kt = 0;
            if (them.ktThem == 1)
                MessageBox.Show("Thông tin thêm vào không hợp lệ hoặc đang trống.", "THÔNG BÁO:");
            else
            {
                while (a != null)
                {
                    if (them.temp.LoaiSach == a.info.LoaiSach)
                    {
                        kt = 1; //Nếu MaSach bị trùng thì thay đổi biến kt để không thêm vào danh sách liên kết.  
                        MessageBox.Show("Đã có trong danh sách");
                    }
                    a = a.Next;
                }
                if (kt == 0 && them.temp.LoaiSach != null)
                {

                    myList.addHead(them.temp);
                    //myList.Sort();
                    MessageBox.Show("Thêm loại sách thành công.", "THÔNG BÁO:");
                }
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            XoaLoaiSach xoa = new XoaLoaiSach();
            xoa.ShowDialog();
            int kt = 0;
            Node a = new Node();
            a = myList.Head;
            while (a != null)
            {
                if (xoa.Lxoa == a.info.LoaiSach)
                {
                    kt = 1;
                }
                a = a.Next;
            }
            if (kt == 1)
            {
                myList.removeKeyLS(myList, xoa.Lxoa);
                MessageBox.Show("Xóa thành công.", "THÔNG BÁO:");
                XoaLoaiSach xls = new XoaLoaiSach();
                //File.WriteAllLines("test.txt", File.ReadLines("Sach.txt").Where(s => !s.StartsWith("/" + xls.textBox1.Text)));
            }
            else MessageBox.Show("Xóa không thành công. \nLoại sách muốn xóa không tồn tại " +
                "hoặc bạn chưa nhập Loại sách cần xóa", "THÔNG BÁO:");
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            SuaLoaiSach sua = new SuaLoaiSach();
            sua.ShowDialog();
            int kt = 0;
            Node Lthaydoi = new Node();
            Lthaydoi = myList.Head;
            while (Lthaydoi != null)
            {
                if (Lthaydoi.info.LoaiSach == sua.loaisach)
                {
                    Lthaydoi.info = sua.Ltd;
                    kt = 1;
                }
                Lthaydoi = Lthaydoi.Next;
            }
            if (kt == 1) MessageBox.Show("Thay đổi thông tin loại sách thành công.", "THÔNG BÁO:");
            else MessageBox.Show("Không tồn tại loại sách cần thay đổi thông tin", "THÔNG BÁO:");
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            try
            {
                myList.clear(myList); //Xóa hết dữ liệu đã tồn tại trong danh sách liên kết
                StreamReader rd = new StreamReader("LoaiSach.txt", Encoding.UTF8); //Đọc file text
                if (rd == null) MessageBox.Show("Đọc file không thành công.", "THÔNG BÁO:");
                string x = rd.ReadLine();           /// doc so cuon sach              
                soloaisach = Convert.ToInt32(x);        /// 
                rd.ReadLine();                      /// doc text

                for (int i = 0; i < soloaisach; i++)
                {
                    string x1 = rd.ReadLine();
                    dsChuoi.Add(x1);
                }
                for (int j = 0; j < soloaisach; j++)
                {
                    SACH x2 = new SACH();
                    string[] thongtin = dsChuoi[j].Split('/');
                    
                    x2.Nhap2(thongtin[1], thongtin[2], thongtin[3] );
                    myList.addHead(x2);

                }
                //myList.Sort(); /// loi
                if (rd != null) MessageBox.Show("Lấy dữ liệu thành công.", "THÔNG BÁO:");
                rd.Close();
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> dsDong = new List<string>();
                FileStream fs = new FileStream("LoaiSach.txt", FileMode.OpenOrCreate);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                soloaisach = myList.CountNode(myList);
                sWriter.WriteLine(soloaisach);
                //sWriter.WriteLine("LoaiSach/TacGia/NXB");
                Node temp = new Node();
                temp = myList.Head;
                string ap = "LoaiSach/TacGia/NXB";
                dsDong.Add(ap);
                //temp = temp.Next;
                while (temp != null)
                {
                    string dong = "/" + temp.info.LoaiSach + "/" + temp.info.TacGia + "/" + temp.info.NXB;
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

        private void Xuat_Click(object sender, EventArgs e)
        {
            try
            {                
                Node xuat1 = myList.Head;               
                string ap = "Loại Sách \t\t Thể Loại Sách \t\t Nhà Xuất Bản \r\n";
                while (xuat1 != null)
                {
                    string loaisach = xuat1.info.LoaiSach;
                    string tacgia = xuat1.info.TacGia;
                    string nxb = xuat1.info.NXB;                  
                    xuat1 = xuat1.Next;
                    ap += "LoaiSach: " + loaisach + "                               ";
                    ap += "TheLoai: " + tacgia + "                                              ";                    
                    ap += "NXB: " + nxb + Environment.NewLine;

                }
                textBox1.Text = ap;
                if (myList.Head == null) MessageBox.Show("Danh sách loại sách đang rỗng. \nHãy LẤY DỮ LIỆU hoặc THÊM", "THÔNG BÁO:");
                else MessageBox.Show("Xuất thành công.", "THÔNG BÁO:");
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiSach them = new ThemLoaiSach();
            them.ShowDialog();
            Node a = new Node();
            SACH Lthem = new SACH();
            Lthem = them.temp;
            a = myList.Head;
            int kt = 0;
            if (them.ktThem == 1)
                MessageBox.Show("Thông tin thêm vào không hợp lệ hoặc đang trống.", "THÔNG BÁO:");
            else
            {
                while (a != null)
                {
                    if (them.temp.LoaiSach == a.info.LoaiSach)
                    {
                        kt = 1; //Nếu MaSach bị trùng thì thay đổi biến kt để không thêm vào danh sách liên kết.  
                        MessageBox.Show("Đã có trong danh sách");
                    }
                    a = a.Next;
                }
                if (kt == 0 && them.temp.LoaiSach != null)
                {

                    myList.addTail(them.temp);
                    //myList.Sort();
                    MessageBox.Show("Thêm loại sách thành công.", "THÔNG BÁO:");
                }
            }
        }
    }
}
