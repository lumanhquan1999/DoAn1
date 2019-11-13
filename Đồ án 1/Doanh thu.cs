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
    public partial class Doanh_thu : Form
    {
        List<Node> lnv1 = new List<Node>();
        public LinkedList myList = new LinkedList();
        List<string> dsChuoi = new List<string>();
        //public int sohoadon;
        public Doanh_thu()
        {
            InitializeComponent();
        }
        
        private void Luu_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> dsDong = new List<string>();
                FileStream fs = new FileStream("Doanhthu.txt", FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sWriter.WriteLine("MaSach/TenSach/LoaiSach/DonGia/NgayMua/SoLuongMua/TongTien/GiamGia/ThanhTien");
                for (int i = 0; i < lnv1.Count; i++)
                {
                    string dong = "/" + lnv1[i].info.MaSach + "/" + lnv1[i].info.TenSach + "/"  + lnv1[i].info.LoaiSach + "/" + lnv1[i].info.DonGia + "/" + lnv1[i].info.NgayMua + "/" + lnv1[i].info.SoLuongMua + "/" + lnv1[i].info.TongTien + lnv1[i].info.GiamGia + "/" + lnv1[i].info.ThanhTien;
                    dsDong.Add(dong);
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
                lnv1 = new List<Node>();
                string ap = "";

                float M = myList.Head.info.ThanhTien;
                for (Node N = myList.Head; N.Next != null; N = N.Next)
                {
                    if (N.info.ThanhTien < 10) continue;
                    if (N.info.ThanhTien > 10)
                    {                        
                        lnv1.Add(N);
                        M = N.info.ThanhTien;
                    }                   
                }
                float sumsoluong = 0;
                float sumtien = 0;
                float count = 0;
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Không có thông tin. Xin nhập 1 mã sách bất kỳ", "THÔNG BÁO:");
                }
                else
                {
                    for (int i = lnv1.Count - 1; i >= 0; i--)
                    {
                        string masach = lnv1[i].info.MaSach;
                        string tensach = lnv1[i].info.TenSach;
                        string loaisach = lnv1[i].info.LoaiSach;
                        float dongia = lnv1[i].info.DonGia;
                        string ngaymua = lnv1[i].info.NgayMua;
                        float soluongmua = lnv1[i].info.SoLuongMua;
                        float tongtien = lnv1[i].info.TongTien;
                        float giamgia = lnv1[i].info.GiamGia;
                        float thanhtien = lnv1[i].info.ThanhTien;
                        if (masach == textBox2.Text)
                        {
                            ap += "MaSach: " + masach + "    ";
                            ap += "TenSach: " + tensach + "     ";
                            ap += "LoaiSach: " + loaisach + "       ";
                            ap += "DonGia: " + dongia + "       ";
                            //ap += "NgayMua: " + ngaymua + "         ";
                            ap += "SoLuongMua: " + soluongmua + " \t ";
                            // ap += "TongTien: " + tongtien + " \t ";
                            //ap += "GiamGia: " + giamgia + " \t ";
                            ap += "ThanhTien: " + thanhtien + Environment.NewLine;
                            sumsoluong += soluongmua;
                            sumtien += thanhtien;
                            count += 1;
                        }
                    }
                    ap += Environment.NewLine;
                    ap += "Tổng số lần đã bán : " + count + Environment.NewLine;
                    ap += "Tổng số lượng đã bán : " + sumsoluong + Environment.NewLine;
                    ap += "Tổng số tiền đã thu về : " + sumtien + Environment.NewLine;
                    myList.Sort2();
                    textBox1.Text = ap;                    
                    if (myList.Head == null) MessageBox.Show("Danh sách sách đang rỗng. \nHãy LẤY DỮ LIỆU hoặc THÊM", "THÔNG BÁO:");
                    else MessageBox.Show("Xuất thành công.", "THÔNG BÁO:");
                    string Textview = textBox1.Text;
                    System.IO.File.WriteAllText("6res.txt", Textview);
                }
            }
            catch(Exception ed) { MessageBox.Show(ed.Message); }
        }        
    }
}
