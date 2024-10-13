namespace BTVN4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập danh sách hành khách
            Console.Write("Nhập số lượng hành khách: ");
            int n = int.Parse(Console.ReadLine());
            List<Hanhkhach> danhSachHK = new List<Hanhkhach>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin hành khách thứ {i + 1}:");
                Hanhkhach hk = new Hanhkhach();
                hk.Nhap();
                danhSachHK.Add(hk);
            }

            // Hiển thị danh sách hành khách và số tiền phải trả
            Console.WriteLine("\nDanh sách hành khách và số tiền phải trả:");
            foreach (var hk in danhSachHK)
            {
                hk.Xuat();
                Console.WriteLine($"Tổng tiền phải trả: {hk.TongTien()} VND");
            }

            // Sắp xếp danh sách hành khách theo tổng tiền giảm dần
            danhSachHK.Sort((hk1, hk2) => hk2.TongTien().CompareTo(hk1.TongTien()));

            // Hiển thị danh sách sau khi sắp xếp
            Console.WriteLine("\nDanh sách hành khách sau khi sắp xếp theo tổng tiền giảm dần:");
            foreach (var hk in danhSachHK)
            {
                hk.Xuat();
                Console.WriteLine($"Tổng tiền phải trả: {hk.TongTien()} VND");
            }
        }
    }
}
