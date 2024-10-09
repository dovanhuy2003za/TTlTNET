using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }

        // Hàm tạo không tham số
        public Nguoi() { }

        // Hàm tạo có tham số
        public Nguoi(string hoTen, string gioiTinh, int tuoi)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
        }

        // Phương thức nhập thông tin người
        public void Nhap()
        {
            Console.Write("Nhập họ và tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }

        // Phương thức xuất thông tin người
        public void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Giới tính: {GioiTinh}, Tuổi: {Tuoi}");
        }
    }
}
