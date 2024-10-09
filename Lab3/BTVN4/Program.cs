using System.Collections;

namespace BTVN4
{
    internal class Program
    {
        //static ArrayList danhSachSinhVien = new ArrayList();
        static List<SinhVien> listsv = new List<SinhVien>();
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
           
            SinhVien sv1 = new SinhVien("211500", "do van huy", 2003, "hanoi", "a10");
            SinhVien sv2 = new SinhVien("2115004", "do van huy1", 2002, "hanoi", "a10");
            SinhVien sv3 = new SinhVien("2115005", "do van huy2", 2004, "hanoi", "a10");
            SinhVien sv4 = new SinhVien("2115006", "do van huy3", 2001, "hanoi", "a10");
            listsv.Add(sv1);
            listsv.Add(sv2);
            listsv.Add(sv3);
            listsv.Add(sv4);
            while (true)
            {
                HienThiMenu();
                Console.Write("Chọn chức năng (1-5): ");
                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        ThemSinhVien();
                        break;
                    case "2":
                        SuaSinhVien();
                        break;
                    case "3":
                        XoaSinhVien();
                        break;
                    case "4":
                        XuatSoLuongSinhVien();
                        break;
                    case "5":
                        XuatDanhSachSinhVienTheoLop();
                        break;
                    case "6":
                        /*try
                        {
                            danhSachSinhVien.Sort(new SapXepTheoNamSinh());

                            foreach (SinhVien sv in danhSachSinhVien)
                            {
                                sv.HienThiThongTin();
                            }
                        }
                        catch (Exception ex) { Console.WriteLine("Loi" + ex); }*/
                        listsv.Sort();
                        foreach (SinhVien sv in listsv)
                        {
                            sv.HienThiThongTin();
                        }

                        break;
                    case "0":
                        Console.WriteLine("Thoát chương trình. Xin chào!");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

                Console.WriteLine("\nNhấn phím Enter bất kỳ để tiếp tục...");
                Console.ReadKey();
                
            }
            static void HienThiMenu()
            {
                Console.WriteLine("===== QUẢN LÝ SINH VIÊN =====");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Sửa thông tin sinh viên");
                Console.WriteLine("3. Xóa sinh viên");
                Console.WriteLine("4. Xuất ra số lượng sinh viên");
                Console.WriteLine("5. Xuất danh sách sinh viên theo lớp học");
                Console.WriteLine("6. Sắp xếp theo năm sinh giảm dần");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("==============================");
            }

            // Hàm thêm sinh viên
            static void ThemSinhVien()
            {
                Console.WriteLine("=== Thêm Sinh Viên ===");
                Console.Write("Mã số sinh viên: ");
                string maSo = Console.ReadLine();

                // Kiểm tra mã số sinh viên đã tồn tại hay chưa
                if (TimSinhVienTheoMa(maSo) != null)
                {
                    Console.WriteLine("Mã số sinh viên đã tồn tại. Vui lòng nhập mã số khác.");
                    return;
                }

                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();

                Console.Write("Năm sinh: ");
                if (!int.TryParse(Console.ReadLine(), out int namSinh))
                {
                    Console.WriteLine("Năm sinh phải là số nguyên. Thêm sinh viên thất bại.");
                    return;
                }

                Console.Write("Địa chỉ: ");
                string diaChi = Console.ReadLine();

                Console.Write("Lớp học: ");
                string lopHoc = Console.ReadLine();

                SinhVien sv = new SinhVien(maSo, hoTen, namSinh, diaChi, lopHoc);
                //danhSachSinhVien.Add(sv);
                listsv.Add(sv);
                Console.WriteLine("Thêm sinh viên thành công!");
            }

            // Hàm sửa thông tin sinh viên
            static void SuaSinhVien()
            {
                Console.WriteLine("=== Sửa Thông Tin Sinh Viên ===");
                Console.Write("Nhập mã số sinh viên cần sửa: ");
                string maSo = Console.ReadLine();

                SinhVien sv = TimSinhVienTheoMa(maSo);
                if (sv == null)
                {
                    Console.WriteLine("Không tìm thấy sinh viên với mã số đã nhập.");
                    return;
                }

                Console.WriteLine("Nhập thông tin mới (để trống nếu không thay đổi):");

                Console.Write("Họ tên ({0}): ", sv.HoTen);
                string hoTen = Console.ReadLine();
                if (!string.IsNullOrEmpty(hoTen))
                    sv.HoTen = hoTen;

                Console.Write("Năm sinh ({0}): ", sv.NamSinh);
                string namSinhStr = Console.ReadLine();
                if (!string.IsNullOrEmpty(namSinhStr))
                {
                    if (int.TryParse(namSinhStr, out int namSinh))
                        sv.NamSinh = namSinh;
                    else
                        Console.WriteLine("Năm sinh không hợp lệ. Không thay đổi.");
                }

                Console.Write("Địa chỉ ({0}): ", sv.DiaChi);
                string diaChi = Console.ReadLine();
                if (!string.IsNullOrEmpty(diaChi))
                    sv.DiaChi = diaChi;

                Console.Write("Lớp học ({0}): ", sv.LopHoc);
                string lopHoc = Console.ReadLine();
                if (!string.IsNullOrEmpty(lopHoc))
                    sv.LopHoc = lopHoc;

                Console.WriteLine("Cập nhật thông tin sinh viên thành công!");
            }

            // Hàm xóa sinh viên
            static void XoaSinhVien()
            {
                Console.WriteLine("=== Xóa Sinh Viên ===");
                Console.Write("Nhập mã số sinh viên cần xóa: ");
                string maSo = Console.ReadLine();

                SinhVien sv = TimSinhVienTheoMa(maSo);
                if (sv == null)
                {
                    Console.WriteLine("Không tìm thấy sinh viên với mã số đã nhập.");
                    return;
                }

                //danhSachSinhVien.Remove(sv);
                listsv.Remove(sv);
                Console.WriteLine("Xóa sinh viên thành công!");
            }

            // Hàm xuất ra số lượng sinh viên
            static void XuatSoLuongSinhVien()
            {
                Console.WriteLine("=== Số Lượng Sinh Viên ===");
                //Console.WriteLine($"Tổng số sinh viên: {danhSachSinhVien.Count}");
                Console.WriteLine($"Tổng số sinh viên: {listsv.Count}");

            }

            // Hàm xuất danh sách sinh viên theo lớp học
            static void XuatDanhSachSinhVienTheoLop()
            {
                Console.WriteLine("=== Danh Sách Sinh Viên Theo Lớp Học ===");
                Console.Write("Nhập lớp học: ");
                string lopHoc = Console.ReadLine();

                bool timThay = false;
                foreach (SinhVien sv in listsv)
                {
                    if (sv.LopHoc.Equals(lopHoc, StringComparison.OrdinalIgnoreCase))
                    {
                        if (!timThay)
                        {
                            Console.WriteLine($"\nDanh sách sinh viên thuộc lớp {lopHoc}:");
                            Console.WriteLine("------------------------------");
                            timThay = true;
                        }
                        sv.HienThiThongTin();
                    }
                }

                if (!timThay)
                {
                    Console.WriteLine($"Không có sinh viên nào thuộc lớp {lopHoc}.");
                }
            }

            // Hàm tìm sinh viên theo mã số
            static SinhVien TimSinhVienTheoMa(string maSo)
            {
                foreach (SinhVien sv in listsv)
                {
                    if (sv.MaSo.Equals(maSo, StringComparison.OrdinalIgnoreCase))
                        return sv;
                }
                return null;
            }
        }

        
    }
}

