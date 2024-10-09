using System.Xml.Linq;

namespace buoi1_TTnet
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Bai 1
            SinhVien sv1= new SinhVien("21103100502","Do van Huy","Ha Noi",15);
            sv1.hienthi();
            SinhVien sv2 = new SinhVien();
            sv2.Ma = "2155454";
            sv2.Hoten = "Do Van Huy";
            sv2.Quequan = "Ha Tay";
            sv2.Khoa = 13;

            sv2.hienthi();
            //bai 2
            /*
            Console.WriteLine("\n \n  Bai 2: ");
            Box box1=new Box(); 
            Box box2=new Box();
            double the_tich = 0;
            box1.dai = 3;
            box1.rong = 2;
            box1.cao = 3;
            box2.dai = 2;
            box2.rong = 4;
            box2.cao = 6;
            the_tich=box1.dai*box1.rong*box1.cao;
            Console.WriteLine("the tich box 1: "+the_tich);
            the_tich=box2.dai*box2.rong*box2.cao;
            Console.WriteLine("the tich box 2: " + the_tich);
            */
            //Bai 3
            SinhVienIT svit1 = new SinhVienIT();
            svit1.Ma = "454666546";
            svit1.Hoten = " Huy van Do";
            svit1.Quequan = "Ha Noi";
            svit1.Khoa = 16;
            svit1.hienthi();
            SinhVienIT svit2 = new SinhVienIT();
            svit2.Ma = "546544";
            svit2.Hoten = "Do v Huy";
            svit2.Quequan = "ha tay";
            svit2.Khoa = 12;
            svit2.hienthi() ;

            // bai 4
            Console.WriteLine("\n -----------\n ");
            Person myPerson = new Person();
            myPerson.loichao();
            Console.WriteLine();
            Students myStudents = new Students();
            myStudents.setAge(21);
            myStudents.loichao() ;
            myStudents.thongBaoTuoi();
            Console.WriteLine();
            Teachers myTeachers = new Teachers();
            myTeachers.setAge(40);
            myTeachers.loichao();
            myTeachers.giangDay();

            Console.ReadKey();

        }
    }
}
