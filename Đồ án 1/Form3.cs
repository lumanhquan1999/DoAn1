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
    public partial class _6 : Form
    {
        LinkedList myList = new LinkedList();
        List<string> dsChuoi = new List<string>();
        public int sohoadon;
        public _6()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            Them6 them = new Them6();
            them.ShowDialog();
            Node p = new Node();
            SACH Sthem = new SACH();
            Sthem = them.temp;
            p = myList.Head;
            float kt = 0;
            if (them.ktThem == 1)
                MessageBox.Show("Thông tin thêm vào không hợp lệ hoặc đang trống.", "THÔNG BÁO:");
            else
            {
                while (p != null)
                {
                    /*if (them.temp.MaSach == p.info.MaSach)
                    {
                        kt = 1; //Nếu MaSach bị trùng thì thay đổi biến kt để không thêm vào danh sách liên kết.  
                        MessageBox.Show("Đã có trong danh sách");
                    }*/
                    p = p.Next;
                }
                if (kt == 0 && them.temp.MaSach != null)
                {
                    them.temp.TongTien = them.temp.SoLuongMua * them.temp.DonGia;
                    if (them.temp.TongTien > 500000 && them.temp.TongTien < 2000000)
                    {
                        them.temp.GiamGia = 0.2F;
                    }
                    else if (them.temp.TongTien > 200000 && them.temp.TongTien < 500000)
                    {
                        them.temp.GiamGia = 0.1F;
                    }
                    else if ((them.temp.TongTien > 2000000) || (them.temp.SoLuongMua > 100))
                    {
                        them.temp.GiamGia = 0.3F;
                    }
                    else
                    {
                        them.temp.GiamGia = 0F;
                    }
                    them.temp.ThanhTien = them.temp.TongTien - (them.temp.GiamGia * them.temp.TongTien);
                    myList.addHead(them.temp);                                     
                    MessageBox.Show("Thêm sách thành công.", "THÔNG BÁO:");
                    
                    string secondLine;
                    using (var reader = new StreamReader("6.txt"))
                    {
                        reader.ReadLine(); // skip
                        secondLine = reader.ReadLine();
                    }
                    secondLine = string.Format("{0,-4}/{1,-40}/{2,-1}/{3,-7}/{4,-12}/{5,-3}/{6,-8}/{7,-2}/{8,-9}/", them.temp.MaSach, them.temp.TenSach, them.temp.LoaiSach, them.temp.DonGia, them.temp.NgayMua, them.temp.SoLuongMua, them.temp.TongTien, them.temp.GiamGia, them.temp.ThanhTien);
                    string filename = "10.txt";
                    //File.AppendAllText(filename, Environment.NewLine);
                    File.AppendAllText(filename, secondLine + Environment.NewLine);
                    //File.AppendAllText(filename, Environment.NewLine);
                }
            }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> dsDong = new List<string>();
                FileStream fs = new FileStream("6.txt", FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sohoadon = myList.CountNode(myList);
                sWriter.WriteLine(sohoadon);                
                Node temp = new Node();
                temp = myList.Head;
                while (temp != null)
                {
                    string dong = "/" + temp.info.MaSach + "/" + temp.info.TenSach + "/" + temp.info.LoaiSach + "/" + temp.info.DonGia + "/" + temp.info.NgayMua + "/" + temp.info.SoLuongMua + "/" + temp.info.TongTien + "/" + temp.info.GiamGia + "/" + temp.info.ThanhTien;
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

        private void Xuat_Click(object sender, EventArgs e)
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
                    string ngaymua = xuat1.info.NgayMua;
                    float soluongmua = xuat1.info.SoLuongMua;
                    float tongtien = xuat1.info.TongTien;
                    float giamgia = xuat1.info.GiamGia;
                    float thanhtien = xuat1.info.ThanhTien;
                    xuat1 = xuat1.Next;
                    
                    ap += "MaSach: " + masach + "    ";
                    ap += "TenSach: " + tensach + "         ";
                    ap += "LoaiSach: " + loaisach + "       ";
                    ap += "DonGia: " + dongia + "       ";
                    ap += "NgayMua: " + ngaymua + "         ";
                    ap += "SoLuongMua: " + soluongmua + " \t ";
                    ap += "TongTien: " + tongtien + " \t ";
                    ap += "GiamGia: " + giamgia + " \t ";
                    ap += "ThanhTien: " + thanhtien + Environment.NewLine;
                    //ap += string.Format("{0,-5}{1,-40}{2,-5}{3,-7}{4,-12}{5,-3}{6,-8}{7,-2}{8,-9}", masach, tensach, loaisach, dongia, ngaymua, soluongmua, tongtien, giamgia, thanhtien) + Environment.NewLine;
                }
                textBox1.Text = ap;
                if (myList.Head == null) MessageBox.Show("Danh sách sách đang rỗng. \nHãy LẤY DỮ LIỆU hoặc THÊM", "THÔNG BÁO:");
                else MessageBox.Show("Xuất thành công.", "THÔNG BÁO:");
            }
            catch { }
        }

        private void Doc_Click(object sender, EventArgs e)
        {
            try
            {
                myList.clear(myList); //Xóa hết dữ liệu đã tồn tại trong danh sách liên kết
                StreamReader rd = new StreamReader("6.txt", Encoding.UTF8); //Đọc file text
                if (rd == null) MessageBox.Show("Đọc file không thành công.", "THÔNG BÁO:");                
                string x = rd.ReadLine();           // doc so cuon sach              
                sohoadon = Convert.ToInt32(x);        
                for (int i = 0; i < sohoadon; i++)
                {
                    string x1 = rd.ReadLine();
                    dsChuoi.Add(x1);
                }
                for (int j = 0; j < sohoadon; j++)
                {
                    SACH x2 = new SACH();
                    string[] thongtin = dsChuoi[j].Split('/');                   
                    x2.Nhap6(thongtin[1], thongtin[2], thongtin[3], float.Parse(thongtin[4]), thongtin[5], float.Parse(thongtin[6]));
                    x2.TongTien = float.Parse(thongtin[7]);
                    x2.GiamGia = float.Parse(thongtin[8]);
                    x2.ThanhTien = float.Parse(thongtin[9]);
                    myList.addHead(x2);
                }
                if (rd != null) MessageBox.Show("Lấy dữ liệu thành công.", "THÔNG BÁO:");
                rd.Close();
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }

        private void Doanhthu_Click(object sender, EventArgs e)
        {
            Doanh_thu doanhthu = new Doanh_thu();
            doanhthu.myList = myList;
            doanhthu.ShowDialog();
        }

        private void BestSell_Click(object sender, EventArgs e)
        {
            BestSell bestsell = new BestSell();
            bestsell.myList = myList;
            bestsell.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them6 them = new Them6();
            them.ShowDialog();
            Node p = new Node();
            SACH Sthem = new SACH();
            Sthem = them.temp;
            p = myList.Head;
            float kt = 0;
            if (them.ktThem == 1)
                MessageBox.Show("Thông tin thêm vào không hợp lệ hoặc đang trống.", "THÔNG BÁO:");
            else
            {
                while (p != null)
                {                   
                    /*if (them.temp.MaSach == p.info.MaSach)
                    {
                        kt = 1; //Nếu MaSach bị trùng thì thay đổi biến kt để không thêm vào danh sách liên kết.  
                        MessageBox.Show("Đã có trong danh sách");
                    }*/
                    p = p.Next;
                }
                if (kt == 0 && them.temp.MaSach != null)
                {
                    them.temp.TongTien = them.temp.SoLuongMua * them.temp.DonGia;
                    if (them.temp.TongTien > 500000 && them.temp.TongTien < 2000000)
                    {
                        them.temp.GiamGia = 0.2F;
                    }
                    else if (them.temp.TongTien > 200000 && them.temp.TongTien < 500000)
                    {
                        them.temp.GiamGia = 0.1F;
                    }
                    else if ((them.temp.TongTien > 2000000) || (them.temp.SoLuongMua > 100))
                    {
                        them.temp.GiamGia = 0.3F;
                    }
                    else
                    {
                        them.temp.GiamGia = 0F;
                    }
                    them.temp.ThanhTien = them.temp.TongTien - (them.temp.GiamGia * them.temp.TongTien);
                    myList.addTail(them.temp);
                    MessageBox.Show("Thêm sách thành công.", "THÔNG BÁO:");
                    string lastLine = File.ReadLines("6.txt").Last();
                    lastLine = string.Format("{0,-4}/{1,-40}/{2,-1}/{3,-7}/{4,-12}/{5,-3}/{6,-8}/{7,-2}/{8,-9}/", them.temp.MaSach, them.temp.TenSach, them.temp.LoaiSach, them.temp.DonGia, them.temp.NgayMua, them.temp.SoLuongMua, them.temp.TongTien, them.temp.GiamGia, them.temp.ThanhTien);
                    string filename = "10.txt";
                    //File.AppendAllText(filename, Environment.NewLine);
                    File.AppendAllText(filename, lastLine + Environment.NewLine);
                    //File.AppendAllText(filename, Environment.NewLine);
                    //File.WriteAllText("10test.txt", secondLine);
                }
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("10.txt");
            foreach (string line in lines)
            {
                try
                {
                    if (line.StartsWith(textBox2.Text.Trim()))
                    {
                        var l1 = line.Split(new string[] { "/" }, StringSplitOptions.None);
                        foreach (String s in l1)
                        {
                            if (s.Length == 4)
                            {
                                // string s1 = s.PadRight(4);
                                textBox1.AppendText("BILL TÍNH TIỀN");
                                textBox1.AppendText(Environment.NewLine);
                                textBox1.AppendText("Mã Sách: " + s);
                                textBox1.AppendText(Environment.NewLine);
                            }
                            if (s.Length == 40)
                            {
                                textBox1.AppendText("Tên Sách: " + s);
                                textBox1.AppendText(Environment.NewLine);
                            }
                            if (s.Length == 1)
                            {

                                textBox1.AppendText("Loại Sách: " + s);
                                textBox1.AppendText(Environment.NewLine);
                            }
                            if (s.Length == 7)
                            {
                                textBox1.AppendText("Đơn Giá: " + s);
                                textBox1.AppendText(Environment.NewLine);
                            }
                            if (s.Length == 12)
                            {
                                textBox1.AppendText("Ngày Mua Hàng: " + s);
                                textBox1.AppendText(Environment.NewLine);
                            }
                            if (s.Length == 3)
                            {
                                textBox1.AppendText("Số Lượng mua: " + s);
                                textBox1.AppendText(Environment.NewLine);
                            }
                            if (s.Length == 8)
                            {
                                textBox1.AppendText("Tổng tiền: " + s);
                                textBox1.AppendText(Environment.NewLine);
                            }
                            if (s.Length == 2)
                            {
                                textBox1.AppendText("Giảm Giá: " + s);
                                textBox1.AppendText(Environment.NewLine);
                            }
                            if (s.Length == 9)
                            {
                                textBox1.AppendText("Thành Tiền: " + s);
                                textBox1.AppendText(Environment.NewLine);
                            }
                            else
                            {
                                //textBox1.AppendText(s);
                                //textBox1.AppendText(Environment.NewLine);
                            }
                        }
                    }
                }
                catch (Exception ee) { MessageBox.Show(ee.Message); }
                textBox1.AppendText(Environment.NewLine); //De ngan cach cac bill khac nhau cho de nhin hon
            }
            string softed = textBox1.Text;
            File.WriteAllText("10res.txt", softed);
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
                string lastLine = File.ReadLines("10.txt").Last();
                string firstLine = File.ReadLines("10.txt").First();
                if(firstLine.StartsWith(xoa.tMaSach.Text))
                {
                    var flines = File.ReadAllLines("10.txt");
                    File.WriteAllLines("10.txt", flines.Skip(1).ToArray());
                }
                if(lastLine.StartsWith(xoa.tMaSach.Text))
                {
                    var lines = System.IO.File.ReadAllLines("10.txt");
                    System.IO.File.WriteAllLines("10.txt", lines.Take(lines.Length - 1).ToArray());
                }              
                MessageBox.Show("Xóa thành công.", "THÔNG BÁO:");
            }
            else MessageBox.Show("Xóa không thành công. \nLịch sử hóa đơn muốn xóa không tồn tại hoặc bạn chưa nhập MaSach của Bill cần xóa", "THÔNG BÁO:");
        }
    }
}
