using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4
{
    internal class Vemaybay
    {
        public string TenChuyen { get; set; }
        public string NgayBay { get; set; }
        public double GiaVe { get; set; }

        // Hàm tạo không tham số
        public Vemaybay() { }

        // Hàm tạo có tham số
        public Vemaybay(string tenChuyen, string ngayBay, double giaVe)
        {
            TenChuyen = tenChuyen;
            NgayBay = ngayBay;
            GiaVe = giaVe;
        }

        // Phương thức nhập thông tin vé máy bay
        public void Nhap()
        {
            Console.Write("Nhập tên chuyến bay: ");
            TenChuyen = Console.ReadLine();
            Console.Write("Nhập ngày bay: ");
            NgayBay = Console.ReadLine();
            Console.Write("Nhập giá vé: ");
            GiaVe = double.Parse(Console.ReadLine());
        }

        // Phương thức xuất thông tin vé máy bay
        public void Xuat()
        {
            Console.WriteLine($"Chuyến bay: {TenChuyen}, Ngày bay: {NgayBay}, Giá vé: {GiaVe}");
        }

        // Hàm trả về giá vé
        public double getGiaVe()
        {
            return GiaVe;
        }
    }
}
