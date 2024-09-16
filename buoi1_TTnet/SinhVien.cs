using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1_TTnet
{
    internal class SinhVien
    {
        private string ma;
        private string hoten;
        private string quequan;
        private int khoa;

        public SinhVien()
        {
        }

        public SinhVien(string ma, string hoten, string quequan, int khoa)
        {
            this.ma = ma;
            this.hoten = hoten;
            this.quequan = quequan;
            this.khoa = khoa;
        }

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }

        public string Quequan
        {
            get { return quequan; }
            set { quequan = value; }
        }
        public int Khoa
        {
            get { return khoa; }
            set { khoa = value; }
        }

        public void trangthai()
        {
            Console.Write("Trang thai: ");
            if (this.khoa < 15)
            {
                Console.Write("Da tot nghiep");
            }
            else
            {
                Console.Write("Dang theo hoc");
            }
        }

        public void hienthi()
        {
            Console.WriteLine("Ma sinh vien: " + this.ma);
            Console.WriteLine("Ho ten: " + this.hoten);
            Console.WriteLine("Que quan: " + this.quequan);
            Console.WriteLine("Khoa: " + Convert.ToString(this.khoa));
            trangthai();
        }
    }
}
