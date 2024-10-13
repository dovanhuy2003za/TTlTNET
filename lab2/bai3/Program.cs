namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GiamDoc gd=new GiamDoc();
            gd.hoten = "Do Van Huy";
            gd.tuoi = 21;
            gd.gioitinh = "Nam";
           KeToan kt=new KeToan();
            kt.hoten = "Do Van Huy";
            kt.tuoi = 21;
            kt.gioitinh = "Nam";
           Console.WriteLine("Lop dan xuat 'giam doc' : {0},{1},{2},{3}",gd.hoten,gd.tuoi,gd.gioitinh,gd.ChucVu());
            Console.WriteLine("---------------");
           Console.WriteLine("Lop dan xuat 'ketoan' : {0},{1},{2},{3}", kt.hoten, kt.tuoi, kt.gioitinh, kt.ChucVu());
        }
    }
}
