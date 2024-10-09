namespace bai2list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;  
            List<string> danhSach = new List<string>();

            
           
            danhSach.Add("huy");
            danhSach.Add("dovanhuy");

           
            Console.WriteLine("Danh sách sau khi thêm 2 phần tử:");
            HienThiDanhSach(danhSach);

            Console.WriteLine("\n=== Chèn 1 phần tử vào đầu danh sách ===");
           
            danhSach.Insert(0, "Phần tử được chèn vào đầu");

            
            Console.WriteLine("Danh sách sau khi chèn phần tử vào đầu:");
            HienThiDanhSach(danhSach);

            Console.WriteLine("\n=== Kiểm tra sự tồn tại của một phần tử ===");
           
            Console.Write("Nhập phần tử cần kiểm tra: ");
            string phanTuCanKiemTra = Console.ReadLine();

            bool tonTai = danhSach.Contains(phanTuCanKiemTra);

            if (tonTai)
            {
                Console.WriteLine($"Phần tử \"{phanTuCanKiemTra}\" tồn tại trong danh sách.");
            }
            else
            {
                Console.WriteLine($"Phần tử \"{phanTuCanKiemTra}\" không tồn tại trong danh sách.");
            }

            Console.WriteLine("\nNhấn phím Enter bất kỳ để tiếp tục...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }
            Console.Clear();

        }

       
        static void HienThiDanhSach(List<string> danhSach)
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách trống.");
                return;
            }

            int stt = 1;
            foreach (string phanTu in danhSach)
            {
                Console.WriteLine($"{stt}. {phanTu}");
                stt++;
            }
        }
        }
    }

