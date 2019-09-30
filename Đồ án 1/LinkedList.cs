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
    public class Node
    {
        public SACH info;
        public Node Next;
        // Hàm khởi tạo
        public Node()
        {
        }
        public Node(SACH x, Node next)
        {
            this.info = x;
            this.Next = next;
        }
        // Tạo Node chứa dữ liệu
        public Node CreateNode(SACH x)
        {
            Node p = new Node();
            p.info = new SACH();
            p.info.MaSach = x.MaSach;
            p.info.TenSach = x.TenSach;
            p.info.LoaiSach = x.LoaiSach;
            p.info.DonGia = x.DonGia;
            
            p.Next = null;
            if (p.info == null)
            {
                return null;
            }
            return p;
        }
    }
    public class SACH
    {
        public string MaSach;
        public string TenSach;
        public string LoaiSach;
        public string DonGia;
        
        // Hàm khởi tạo
        public SACH()
        {
        }
        // Hàm nhập 
        public void Nhap(string masach, string tensach, string loaisach, string dongia)
        {
            this.MaSach = masach;
            this.TenSach = tensach;
            this.LoaiSach = loaisach;
            this.DonGia = dongia;
            
        }
    }
    public class LinkedList
    {
        // Khai báo
        public Node Head;
        public Node Tail;
        public List<SACH> found = new List<SACH>(); //Danh sách kiểu SACH để chứa những nhân viên thỏa điều kiện tìm
        // Hàm khởi tạo
        public LinkedList()
        {
            Head = Tail = null;
        }
        // Hàm kiểm tra danh sách liên kết có rỗng hay không
        public int IsEmptyList()
        {
            if (this.Head == null)
                return 1;               // Danh sách rỗng
            return 0;                   // Danh sách không rỗng
        }
        // Thêm vào cuối danh sách
        public void addTail(SACH x)
        {
            Node p = new Node(x, null);
            if (this.Head == null)
                this.Head = this.Tail = p;
            else
            {
                this.Tail.Next = p;
                this.Tail = p;
            }
        }
        //Thêm vào đầu danh sách      
        public void addHead(SACH x)
        {
            Node p = new Node(x, Head);
            Head = p;
            if (Tail == null)
                Tail = Head;
        }
    }
}
