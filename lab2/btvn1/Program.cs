using Bai1;
using System.Text;

namespace btvn1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVienIT sv1 = new SinhVienIT("Nguyen Văn Huy", "Công nghệ thông tin", 8.0);
            sv1.XuatThongTin();
        }
    }
}
