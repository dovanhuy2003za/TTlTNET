using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4
{
    internal class SinhVien:IComparable<SinhVien>
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string LopHoc { get; set; }
        

        // Constructor
        public SinhVien(string maSo, string hoTen, int namSinh, string diaChi, string lopHoc)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NamSinh = namSinh;
            DiaChi = diaChi;
            LopHoc = lopHoc;
        }

        // Phương thức hiển thị thông tin sinh viên
        public void HienThiThongTin()
        {
            Console.WriteLine($"Mã số: {MaSo}");
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Năm sinh: {NamSinh}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
            Console.WriteLine($"Lớp học: {LopHoc}");
            Console.WriteLine("------------------------------");
        }

        public int CompareTo(SinhVien? other)
        {
            return this.NamSinh.CompareTo(other.NamSinh) * (1);
        }
    }
}
