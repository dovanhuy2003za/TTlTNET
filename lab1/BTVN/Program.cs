namespace BTVN1
{
    internal class Program
    {
        class PhanSo
        {
            public double tuso,mauso;

            public PhanSo()
            {
            }
            ~  PhanSo()
            {
            }
            public void nhap()
            {
                Console.Write("Nhap tu so:");
                this.tuso=Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap mau so:");
                this.mauso=Convert.ToDouble(Console.ReadLine());
            }

            public void xuat()
            {
                Console.WriteLine($"Phan so vua nhap: {this.tuso}/{this.mauso}");
            }
            public double tong(PhanSo ps1, PhanSo ps2)
            {
                double tu,mau;
                if (ps1.mauso==ps2.mauso)
                {
                    tu=ps1.tuso+ps2.tuso;
                    mau=ps1 .mauso;
                }
                else
                {
                    mau=ps1.mauso*ps2.mauso;
                    tu=ps1.tuso*ps2.mauso+ps2.tuso*ps1.mauso;
                }
                return (tu/mau);

            }
            public double hieu(PhanSo ps1, PhanSo ps2)
            {
                double tu, mau;
                if (ps1.mauso == ps2.mauso)
                {
                    tu = ps1.tuso - ps2.tuso;
                    mau = ps1.mauso;
                }
                else
                {
                    mau = ps1.mauso * ps2.mauso;
                    tu = ps1.tuso * ps2.mauso - ps2.tuso * ps1.mauso;
                }
                return (tu / mau);
            }
            public double tich(PhanSo ps1, PhanSo ps2)
            {
                double tu, mau;
                tu = ps1.tuso * ps2.tuso;
                mau = ps1.mauso*ps2.mauso;
                return (tu / mau);
            }
            public double thuong(PhanSo ps1, PhanSo ps2)
            {
                double tu, mau;
                tu = ps1.tuso / ps2.tuso;
                mau = ps1.mauso / ps2.mauso;
                return (tu / mau);
            }
        }
        static void Main(string[] args)
        {
            PhanSo ps1=new PhanSo();
            ps1 .nhap();
            ps1 .xuat();
            PhanSo ps2=new PhanSo();
            ps2 .nhap();
            ps2 .xuat();
            PhanSo ps3 = new PhanSo();
            double a=ps3.tong(ps1, ps2);
            double b=ps3.hieu(ps1, ps2);
            double c=ps3.tich(ps1, ps2);
            double d=ps3.thuong(ps1, ps2);
            Console.WriteLine("Tong 2 phan so: " +a);
            Console.WriteLine("Hieu 2 phan so: "+b);
            Console.WriteLine("Tich 2 phan so: " + c);
            Console.WriteLine("Thuong 2 phan so: " + d); 
            Console.ReadKey();
        }
    }
}
