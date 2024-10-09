using bai1;

namespace buoi2_ttnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GiaoDichHangHoa g1=new GiaoDichHangHoa(13,"a12566","21/9/2024");
            GiaoDichHangHoa g2 = new GiaoDichHangHoa(15, "a4865486", "20/9/2024");
            g1.hienThiThongTinGiaoDich();
            Console.WriteLine("---------------------");
            g2.hienThiThongTinGiaoDich();
            
        }
    }
}
