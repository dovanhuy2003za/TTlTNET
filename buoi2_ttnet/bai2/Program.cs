namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {   // bai 2
            //SinhVien sv1 = new SinhVien();
            //sv1.Ma = "21103100502";
            //sv1.Hoten = "Do Van Huy";
            //sv1.Quequan = "Ha Noi";
            //sv1.Khoa = 15;
            //sv1.hienthi();
            //Console.WriteLine("\n-----------------------");
            //Console.WriteLine("  Su dung interface:...");
            //iNguoi sv2 = sv1;
            //sv2.hienthi();

            
            GiamDoc gd=new GiamDoc();
            gd.hoten = "Do Van Huy";
            gd.tuoi = 21;
            gd.gioitinh = "Nam";
            gd.hienthi();
            gd.CongViec();
            Console.WriteLine("---------------");
            KeToan kt = new KeToan();
            kt.hoten = "Do Van Huy";
            kt.tuoi = 21;
            kt.gioitinh = "Nam";
            kt.hienthi();
            kt.CongViec();
        }
    }
}
