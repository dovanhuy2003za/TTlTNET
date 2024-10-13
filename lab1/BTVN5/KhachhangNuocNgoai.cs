using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN5
{
    internal class KhachhangNuocNgoai : KhachHang
    {
        public string QuocTich { get; set; }

        public KhachhangNuocNgoai() { }

        public KhachhangNuocNgoai(string maKhachHang, int soLuong, double donGia, string ngayHoaDon, string hoTen, string quocTich)
            : base(maKhachHang, soLuong, donGia, ngayHoaDon, hoTen)
        {
            QuocTich = quocTich;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập quốc tịch: ");
            QuocTich = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Quốc tịch: {QuocTich}");
        }
    }
}
