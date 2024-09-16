using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN5
{
    internal class KhachHang
    {
        public string MaKhachHang { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }
        public DateTime NgayHoaDon { get; set; }
        public string HoTen { get; set; }

        public KhachHang() { }

        public KhachHang(string maKhachHang, int soLuong, double donGia, string ngayHoaDon, string hoTen)
        {
            MaKhachHang = maKhachHang;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = soLuong * donGia;
            NgayHoaDon = DateTime.ParseExact(ngayHoaDon, "dd/MM/yyyy", null);
            HoTen = hoTen;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập mã khách hàng: ");
            MaKhachHang = Console.ReadLine();
            Console.Write("Nhập số lượng điện tiêu thụ: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhập đơn giá: ");
            DonGia = double.Parse(Console.ReadLine());
            Console.Write("Nhập ngày hóa đơn (dd/MM/yyyy): ");
            NgayHoaDon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Nhập họ tên khách hàng: ");
            HoTen = Console.ReadLine();
            ThanhTien = SoLuong * DonGia;
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Mã khách hàng: {MaKhachHang}, Họ tên: {HoTen}, Số lượng: {SoLuong}, Đơn giá: {DonGia}, Thành tiền: {ThanhTien}, Ngày hóa đơn: {NgayHoaDon:dd/MM/yyyy}");
        }
    }

}
