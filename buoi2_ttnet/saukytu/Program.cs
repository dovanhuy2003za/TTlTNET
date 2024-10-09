namespace saukytu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1,2,3//2.4");

            string str1 = "Do van Huy";
            string str2 = "Do Van Huy Uneti";
            if (String.Compare(str1,str2)==0)
            {
                Console.WriteLine(str1+" va "+str2 + "  giong nhau");
            }
            else
            {
                Console.WriteLine(str1 + "va" + str2 + " 2 Chuoi khac nhau");
            }
            if (str1.Contains("Huy"))
            {
                Console.WriteLine("Tim thay chuoi con 'Huy' trong "+str1);
            }
            else
            {
                Console.WriteLine("ko tim thay chuoi con 'Huy' trong "+str1);
            }
            string str3=str1.Substring(7);
            Console.WriteLine("Chuoi con duoc cat tu chuoi "+str1+" : "+str3);
        }
    }
}
