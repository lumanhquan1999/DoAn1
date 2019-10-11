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
            p.info.NgayMua = x.NgayMua;
            
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
        public string NgayMua;

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
        public List<SACH> found = new List<SACH>(); //Danh sách kiểu SACH để chứa những sách thỏa điều kiện tìm
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
        public void SearchNode(LinkedList myList, string x)
        {
            Node p = myList.Head;
            while (p != null)
            {
                SACH temp = new SACH(); //Biến nhớ kiểu sinh viên để đưa vào list
                if ((x == p.info.MaSach) || (x == p.info.TenSach) || (x == p.info.LoaiSach) || (x == p.info.DonGia) )
                {
                    temp.Nhap(p.info.MaSach, p.info.TenSach, p.info.LoaiSach, p.info.DonGia);
                    found.Add(temp);
                }
                p = p.Next;
            }
        }
        // Xóa phần tử đầu
        public void removeHead(LinkedList myList)
        {
            if (myList.Head == null)
            {
            }
            else if (myList.Head == myList.Tail)
            {
                myList.Head = null;
                /*myList.Head =*/
                myList.Tail = null;
            }
            else
            {
                Node temp = new Node();
                temp = myList.Head;
                myList.Head = myList.Head.Next;
                temp = null;
            }
        }
        // Xóa nút phía sau
        public void removeAfter(LinkedList myList, Node node)
        {
            if (myList.Head == null)
            { }
            else
            {
                Node temp = new Node();
                temp = node.Next;
                if (temp != null)
                {
                    node.Next = temp.Next;
                    temp = null;
                }
            }
        }
        // Xóa nút có giá trị cần xóa
        public void removeKey(LinkedList myList, string x)
        {
            if (myList.Head == null)
            { }
            else
            {
                Node result = new Node();
                result = myList.Head;
                Node before = new Node();
                before = null;
                while (result.info.MaSach != x)
                {
                    before = result;
                    result = result.Next;
                }
                if (result != null)
                {
                    if (result == myList.Head)
                        removeHead(myList);
                    else
                        removeAfter(myList, before);
                }
            }
        }
        // Đếm node
        public int CountNode(LinkedList myList)
        {
            int dem = 0;
            Node p = new Node();
            p = myList.Head;
            while (p != null)
            {
                dem++;
                p = p.Next;
            }
            return dem;
        }
        // Hàm hủy danh sách liên kết
        public void clear(LinkedList myList)
        {
            Node temp = new Node();
            temp = myList.Head;
            while (temp != null)
            {
                myList.removeHead(myList);
                temp = temp.Next;
            }
        }
        //Sắp xếp theo MaSach
        public void Sort()
        {
            LinkedList lnv1 = new LinkedList();
            LinkedList lnv2 = new LinkedList();
            Node pivot, p;
            if (Head == Tail)
                return;
            pivot = Head;
            p = Head.Next;
            string[] masachPivot = pivot.info.MaSach.Split('S');
            while (p != null)
            {
                Node q = p;
                p = p.Next;
                q.Next = null;
                string[] masachQ = q.info.MaSach.Split('S');
                if (Convert.ToInt32(masachQ[1]) < Convert.ToInt32(masachPivot[1]))
                    lnv1.addTail(q.info);
                else
                    lnv2.addTail(q.info);
            };
            lnv1.Sort();
            lnv2.Sort();
            if (lnv1.IsEmptyList() == 0)
            {
                this.Head = lnv1.Head;
                lnv1.Tail.Next = pivot;
            }
            else
                this.Head = pivot;
            pivot.Next = lnv2.Head;
            if (lnv2.IsEmptyList() == 0)
                this.Tail = lnv2.Tail;
            else
                this.Tail = pivot;
        }
    }
}
