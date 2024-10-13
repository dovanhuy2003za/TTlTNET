using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN4
{
    internal class Hanhkhach:Nguoi
    {
        public Vemaybay[] Ve { get; set; }
        public int SoLuong { get; set; }

        // Hàm tạo không tham số
        public Hanhkhach() { }

        // Hàm tạo có tham số
        public Hanhkhach(string hoTen, string gioiTinh, int tuoi, Vemaybay[] ve, int soLuong)
            : base(hoTen, gioiTinh, tuoi)
        {
            Ve = ve;
            SoLuong = soLuong;
        }

        // Phương thức nhập thông tin hành khách và vé máy bay
        public new void Nhap()
        {
            base.Nhap();  // Nhập thông tin cơ bản của hành khách
            Console.Write("Nhập số lượng vé: ");
            SoLuong = int.Parse(Console.ReadLine());
            Ve = new Vemaybay[SoLuong];

            for (int i = 0; i < SoLuong; i++)
            {
                Console.WriteLine($"\nNhập thông tin vé thứ {i + 1}:");
                Ve[i] = new Vemaybay();
                Ve[i].Nhap();
            }
        }

        // Phương thức xuất thông tin hành khách và vé máy bay
        public new void Xuat()
        {
            base.Xuat();  // Xuất thông tin cơ bản của hành khách
            for (int i = 0; i < SoLuong; i++)
            {
                Console.WriteLine($"\nThông tin vé thứ {i + 1}:");
                Ve[i].Xuat();
            }
        }

        // Hàm trả về tổng tiền phải trả
        public double TongTien()
        {
            double tongTien = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                tongTien += Ve[i].getGiaVe();
            }
            return tongTien;
        }
    }
}
