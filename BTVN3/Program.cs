namespace BTVN3
{
    class VanDongVien
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string MonThiDau { get; set; }
        public double CanNang { get; set; }
        public double ChieuCao { get; set; }

        // Hàm tạo không tham số
        public VanDongVien() { }

        // Hàm tạo 5 tham số
        public VanDongVien(string hoTen, int tuoi, string monThiDau, double canNang, double chieuCao)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
            MonThiDau = monThiDau;
            CanNang = canNang;
            ChieuCao = chieuCao;
        }

        // Phương thức hủy (hàm hủy mặc định trong C#)
        ~VanDongVien()
        {
            Console.WriteLine($"Vận động viên {HoTen} đã bị hủy.");
        }

        // Phương thức nhập thông tin vận động viên
        public void Nhap()
        {
            Console.Write("Nhập họ và tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập môn thi đấu: ");
            MonThiDau = Console.ReadLine();
            Console.Write("Nhập cân nặng (kg): ");
            CanNang = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều cao (m): ");
            ChieuCao = double.Parse(Console.ReadLine());
        }

        // Phương thức xuất thông tin vận động viên
        public void Xuat()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Tuổi: {Tuoi}, Môn thi đấu: {MonThiDau}, Cân nặng: {CanNang} kg, Chiều cao: {ChieuCao} m");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo đối tượng p sử dụng hàm tạo 5 tham số
            VanDongVien p = new VanDongVien("Nguyễn Văn A", 25, "Điền kinh", 70.5, 1.75);
            Console.WriteLine("Thông tin vận động viên p:");
            p.Xuat();

            // Nhập vào một mảng gồm n vận động viên
            Console.Write("\nNhập số lượng vận động viên: ");
            int n = int.Parse(Console.ReadLine());
            List<VanDongVien> danhSachVDV = new List<VanDongVien>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin vận động viên thứ {i + 1}:");
                VanDongVien vdv = new VanDongVien();
                vdv.Nhap();
                danhSachVDV.Add(vdv);
            }

            // Hiển thị danh sách đã nhập
            Console.WriteLine("\nDanh sách vận động viên đã nhập:");
            foreach (var vdv in danhSachVDV)
            {
                vdv.Xuat();
            }

            // Sắp xếp danh sách theo thứ tự tăng dần theo tuổi
            danhSachVDV.Sort((vdv1, vdv2) => vdv1.Tuoi.CompareTo(vdv2.Tuoi));

            // Hiển thị danh sách sau khi sắp xếp
            Console.WriteLine("\nDanh sách vận động viên sau khi sắp xếp theo tuổi:");
            foreach (var vdv in danhSachVDV)
            {
                vdv.Xuat();
            }
        }
    }
}
