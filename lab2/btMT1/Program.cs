namespace btMT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding=System.Text.Encoding.UTF8;
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            // Nhập kích thước ma trận
            Console.Write("Nhập số dòng của ma trận: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột của ma trận: ");
            int cols = int.Parse(Console.ReadLine());

            // Khai báo và khởi tạo hai ma trận
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] sumMatrix = new int[rows, cols];

            // Nhập giá trị cho ma trận 1
            Console.WriteLine("Nhập các phần tử cho ma trận thứ nhất:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix1[{i},{j}] = ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Nhập giá trị cho ma trận 2
            Console.WriteLine("Nhập các phần tử cho ma trận thứ hai:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix2[{i},{j}] = ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ma trận 1 là:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Ma trận 2 là:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Tính tổng hai ma trận
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Hiển thị ma trận tổng
            Console.WriteLine("Ma trận tổng là:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(sumMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Tính tổng các phần tử trên đường chéo chính
            int sumDiagonal1 = 0;
            for (int i = 0; i < rows; i++)
            {
                sumDiagonal1 += matrix1[i, i];
                
            }
            // Hiển thị tổng 
            Console.WriteLine($"Tổng các phần tử trên đường chéo chính ma trận 1 là: {sumDiagonal1}");

            int sumDiagonal2 = 0;
            for (int i = 0; i < rows; i++)
            {
                sumDiagonal2 += matrix2[i, i];

            }
            // Hiển thị tổng
            Console.WriteLine($"Tổng các phần tử trên đường chéo chính ma trận 2 là: {sumDiagonal2}");

            int sumDiagonal3 = 0;
            for (int i = 0; i < rows; i++)
            {
                sumDiagonal3 += sumMatrix[i, i];

            }
            // Hiển thị tổng
            Console.WriteLine($"Tổng các phần tử trên đường chéo chính ma trận tổng là: {sumDiagonal3}");
        }
    }
}
