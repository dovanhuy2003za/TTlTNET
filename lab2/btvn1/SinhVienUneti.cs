using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai1
{

    internal abstract class SinhVienUneti
    {

        public string HoTen { get; set; }
        public string Nganh { get; set; }
        public SinhVienUneti(string hoTen, string nganh)
        {
            HoTen = hoTen;
            Nganh = nganh;
        }
        public abstract double getDiem();
        public string getXepLoaiHL()
        {
            double diem = getDiem();
            if (diem >= 8.5)
                return "Giỏi";
            else if (diem >= 7.0)
                return "Khá";
            else if (diem >= 5.5)
                return "Trung Bình";
            else
                return "Yếu";
        }
        public void XuatThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Ngành: {Nganh}");
            Console.WriteLine($"Điểm: {getDiem()}");
            Console.WriteLine($"Học lực: {getXepLoaiHL()}");
        }
    }
}
