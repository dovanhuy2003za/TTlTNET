namespace BTVN5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<KhachHang> danhSachKhachHang = new List<KhachHang>();

            // Nhập danh sách khách hàng
            for (int i = 0; i < 3; i++) // Thay đổi số lượng khách hàng nhập
            {
                Console.WriteLine("Nhập thông tin khách hàng (1: Việt Nam, 2: Nước ngoài): ");
                int loai = int.Parse(Console.ReadLine());
                if (loai == 1)
                {
                    KhachHangVietNam khVN = new KhachHangVietNam();
                    khVN.Nhap();
                    danhSachKhachHang.Add(khVN);
                }
                else if (loai == 2)
                {
                    KhachhangNuocNgoai khNN = new KhachhangNuocNgoai();
                    khNN.Nhap();
                    danhSachKhachHang.Add(khNN);
                }
            }

            // Xuất danh sách khách hàng
            Console.WriteLine("\nDanh sách hóa đơn khách hàng:");
            foreach (var khachHang in danhSachKhachHang)
            {
                khachHang.Xuat();
            }

            // Tính tổng số lượng điện tiêu thụ cho từng loại khách hàng
            int tongSoLuongVN = 0, tongSoLuongNN = 0;
            foreach (var kh in danhSachKhachHang)
            {
                if (kh is KhachHangVietNam)
                    tongSoLuongVN += kh.SoLuong;
                else if (kh is KhachhangNuocNgoai)
                    tongSoLuongNN += kh.SoLuong;
            }
            Console.WriteLine($"\nTổng số lượng điện tiêu thụ của khách hàng Việt Nam: {tongSoLuongVN}");
            Console.WriteLine($"Tổng số lượng điện tiêu thụ của khách hàng nước ngoài: {tongSoLuongNN}");

            // Tính trung bình thành tiền của khách hàng nước ngoài
            double tongThanhTienNN = 0;
            int soLuongKHNN = 0;
            foreach (var kh in danhSachKhachHang)
            {
                if (kh is KhachhangNuocNgoai)
                {
                    tongThanhTienNN += kh.ThanhTien;
                    soLuongKHNN++;
                }
            }
            if (soLuongKHNN > 0)
            {
                double trungBinhThanhTienNN = tongThanhTienNN / soLuongKHNN;
                Console.WriteLine($"Trung bình thành tiền của khách hàng nước ngoài: {trungBinhThanhTienNN}");
            }

            // Xuất các hóa đơn trong tháng 09 năm 2020
            Console.WriteLine("\nCác hóa đơn trong tháng 09 năm 2020:");
            foreach (var kh in danhSachKhachHang)
            {
                if (kh.NgayHoaDon.Month == 9 && kh.NgayHoaDon.Year == 2020)
                {
                    kh.Xuat();
                }
            }
        }
    }
}
