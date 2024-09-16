using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN5
{
    internal class KhachHangVietNam:KhachHang
    {
        public string LoaiKhachHang { get; set; }
        public int DinhMuc { get; set; }

        public KhachHangVietNam() { }

        public KhachHangVietNam(string maKhachHang, int soLuong, double donGia, string ngayHoaDon, string hoTen, string loaiKhachHang, int dinhMuc)
            : base(maKhachHang, soLuong, donGia, ngayHoaDon, hoTen)
        {
            LoaiKhachHang = loaiKhachHang;
            DinhMuc = dinhMuc;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập loại khách hàng: ");
            LoaiKhachHang = Console.ReadLine();
            Console.Write("Nhập định mức: ");
            DinhMuc = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Loại khách hàng: {LoaiKhachHang}, Định mức: {DinhMuc}");
        }
    }
}
