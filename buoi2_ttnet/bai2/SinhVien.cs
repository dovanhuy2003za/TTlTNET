using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class SinhVien:iNguoi
    {
        private string ma;
        private string hoten;
        private string quequan;
        private int khoa;

        public string Ma { get => ma; set => ma = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Quequan { get => quequan; set => quequan = value; }
        public int Khoa { get => khoa; set => khoa = value; }

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
