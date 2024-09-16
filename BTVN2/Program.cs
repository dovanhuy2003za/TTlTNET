namespace BTVN2
{
    class SinhVien
    {
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public int NamSinh { get; set; }
        public double DiemTongKet { get; set; }

        // Hàm tạo
        public SinhVien() { }

        public SinhVien(string hoTen, string queQuan, int namSinh, double diemTongKet)
        {
            HoTen = hoTen;
            QueQuan = queQuan;
            NamSinh = namSinh;
            DiemTongKet = diemTongKet;
        }

        // Phương thức Nhập thông tin
        public void Nhap()
        {
            Console.Write("Nhập họ và tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập quê quán: ");
            QueQuan = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm tổng kết: ");
            DiemTongKet = double.Parse(Console.ReadLine());
        }

        // Phương thức Xuất thông tin
        public void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Quê quán: {QueQuan}, Năm sinh: {NamSinh}, Điểm tổng kết: {DiemTongKet}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();

            // a) Tạo danh sách học sinh
            Console.Write("Nhập số lượng sinh viên: ");
            int soLuong = int.Parse(Console.ReadLine());

            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"\nNhập thông tin sinh viên thứ {i + 1}:");
                SinhVien sv = new SinhVien();
                sv.Nhap();
                danhSachSinhVien.Add(sv);
            }

            // Xuất danh sách sinh viên
            Console.WriteLine("\nDanh sách sinh viên:");
            foreach (var sv in danhSachSinhVien)
            {
                sv.Xuat();
            }

            // b) Sửa thông tin của một sinh viên
            Console.Write("\nNhập tên sinh viên cần sửa: ");
            string tenSua = Console.ReadLine();
            SinhVien svSua = danhSachSinhVien.Find(sv => sv.HoTen == tenSua);
            if (svSua != null)
            {
                Console.WriteLine("Nhập lại thông tin sinh viên:");
                svSua.Nhap();
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên cần sửa.");
            }

            // Xuất lại danh sách sau khi sửa
            Console.WriteLine("\nDanh sách sinh viên sau khi sửa:");
            foreach (var sv in danhSachSinhVien)
            {
                sv.Xuat();
            }

            // c) Xóa thông tin về một sinh viên ra khỏi danh sách
            Console.Write("\nNhập tên sinh viên cần xóa: ");
            string tenXoa = Console.ReadLine();
            SinhVien svXoa = danhSachSinhVien.Find(sv => sv.HoTen == tenXoa);
            if (svXoa != null)
            {
                danhSachSinhVien.Remove(svXoa);
                Console.WriteLine($"Đã xóa sinh viên {tenXoa}.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên cần xóa.");
            }

            // Xuất lại danh sách sau khi xóa
            Console.WriteLine("\nDanh sách sinh viên sau khi xóa:");
            foreach (var sv in danhSachSinhVien)
            {
                sv.Xuat();
            }

            // d) Đưa ra những học sinh có quê quán ở "Nam Định"
            Console.WriteLine("\nDanh sách sinh viên có quê quán ở Nam Định:");
            foreach (var sv in danhSachSinhVien)
            {
                if (sv.QueQuan.ToLower() == "nam định" || sv.QueQuan.ToLower() == "nam định")
                {
                    sv.Xuat();
                }
            }

            // e) Đưa ra những học sinh có điểm tổng kết lớn nhất
            double diemMax = double.MinValue;
            foreach (var sv in danhSachSinhVien)
            {
                if (sv.DiemTongKet > diemMax)
                {
                    diemMax = sv.DiemTongKet;
                }
            }

            Console.WriteLine("\nSinh viên có điểm tổng kết lớn nhất:");
            foreach (var sv in danhSachSinhVien)
            {
                if (sv.DiemTongKet == diemMax)
                {
                    sv.Xuat();
                }
            }
        }
    }
}
