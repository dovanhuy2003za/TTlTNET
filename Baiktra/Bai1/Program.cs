namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            float s = 0;
            while (n < 0 && n > 372145)
            {
               

            }
            Console.Write("Nhap n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s += 1.0F / (2 * i - 1);
            }
            Console.WriteLine("Tong 1+1/3+1/5+...+1/2n-1 la: " + s);
        }
    }
}
