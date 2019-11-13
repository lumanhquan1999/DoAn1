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
    public partial class BestSell : Form
    {
        public List<Node> lmax = new List<Node>();
        public LinkedList myList = new LinkedList();
        List<string> dsChuoi = new List<string>();
        //int sohoadon;
        public BestSell()
        {
            InitializeComponent();
        }        

        private void Xuất_Click(object sender, EventArgs e)
        {
            try
            {
                
                string ap = "";

                float Max = myList.Head.info.SoLuongMua;
                for (Node N = myList.Head; N.Next != null; N = N.Next)
                {
                    if (N.info.SoLuongMua < Max) continue;
                    if (N.info.SoLuongMua > Max)
                    {
                        lmax.Clear();
                        lmax.Add(N);
                        Max = N.info.SoLuongMua;
                    }
                    else
                    {
                        lmax.Add(N);
                    }
                }
                for (int i = lmax.Count - 1; i >= 0; i--)
                {
                    string masach = lmax[i].info.MaSach;
                    string tensach = lmax[i].info.TenSach;
                    string loaisach = lmax[i].info.LoaiSach;
                    float dongia = lmax[i].info.DonGia;
                    string ngaymua = lmax[i].info.NgayMua;
                    float soluongmua = lmax[i].info.SoLuongMua;
                    float tongtien = lmax[i].info.TongTien;
                    float giamgia = lmax[i].info.GiamGia;
                    float thanhtien = lmax[i].info.ThanhTien;
                    ap += "MaSach: " + masach + "    ";
                    ap += "TenSach: " + tensach + "     ";
                    ap += "LoaiSach: " + loaisach + "       ";
                    ap += "DonGia: " + dongia + "       ";
                    ap += "NgayMua: " + ngaymua + "         ";
                    ap += "SoLuongMua: " + soluongmua + " \t ";
                    ap += "TongTien: " + tongtien + " \t ";
                    ap += "GiamGia: " + giamgia + " \t ";
                    ap += "ThanhTien: " + thanhtien + Environment.NewLine;
                }
                textBox1.Text = ap;
                string Textview = textBox1.Text;
                System.IO.File.WriteAllText("7res.txt", Textview);
            }
            catch { }
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> dsDong = new List<string>();
                FileStream fs = new FileStream("BestSell.txt", FileMode.Create);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
                sWriter.WriteLine("MaSach/TenSach/LoaiSach/DonGia/NgayMua/SoLuongMua/TongTien/GiamGia/ThanhTien");
                for (int i = 0; i < lmax.Count; i++)
                {
                    string dong = "/" + lmax[i].info.MaSach + "/" + lmax[i].info.TenSach + "/" + lmax[i].info.LoaiSach + "/" + lmax[i].info.DonGia + "/" + lmax[i].info.NgayMua + "/" + lmax[i].info.SoLuongMua + "/" + lmax[i].info.TongTien + lmax[i].info.GiamGia + "/" + lmax[i].info.ThanhTien;
                    dsDong.Add(dong);
                    sWriter.WriteLine(dsDong[i]);
                }
                sWriter.Flush();
                fs.Close();
                MessageBox.Show("Lưu thành công.", "THÔNG BÁO:");
            }
            catch { }
        }
    }
}
