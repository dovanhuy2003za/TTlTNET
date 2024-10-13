namespace BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Nhập kích thước ma trận
            Console.Write("Nhập số dòng của ma trận: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột của ma trận: ");
            int cols = int.Parse(Console.ReadLine());

            // Khai báo và khởi tạo hai ma trận
            int[,] matrix1 = new int[rows, cols];
           

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

           
            Console.WriteLine("Ma trận 1 là:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }

           

            // Tìm số âm nhỏ nhất
            int? minNegative = null; // Sử dụng kiểu nullable để kiểm tra có số âm không

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix1[i, j] < 0)
                    {
                        if (minNegative == null || matrix1[i, j] < minNegative)
                        {
                            minNegative = matrix1[i, j];
                        }
                    }
                }
            }

            // Hiển thị kết quả
            if (minNegative != null)
            {
                Console.WriteLine($"Số âm nhỏ nhất trong ma trận là: {minNegative}");
            }
            else
            {
                Console.WriteLine("Không có số âm trong ma trận.");
            }

            // Sắp xếp từng cột theo thứ tự tăng dần
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    for (int h = i + 1; h < rows; h++)
                    {
                        if (matrix1[i, j] > matrix1[h, j])
                        {
                            // Hoán đổi giá trị nếu không đúng thứ tự
                            int temp = matrix1[i, j];
                            matrix1[i, j] = matrix1[h, j];
                            matrix1[h, j] = temp;
                        }
                    }
                }
            }

            // Hiển thị ma trận sau khi sắp xếp
            Console.WriteLine("Ma trận sau khi sắp xếp các cột theo thứ tự tăng dần:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Nhập số nguyên dương k
            Console.WriteLine("Nhập số nguyên dương k (cột cần xóa): ");
            int k = int.Parse(Console.ReadLine());

            // Kiểm tra xem k có hợp lệ không
            if (k < 1 || k > cols)
            {
                Console.WriteLine("Cột thứ k không tồn tại.");
            }
            else
            {
                // Tạo ma trận mới sau khi xóa cột thứ k
                int[,] newMatrix = new int[rows, cols - 1];

                for (int i = 0; i < rows; i++)
                {
                    int newColIndex = 0;
                    for (int j = 0; j < cols; j++)
                    {
                        if (j == k - 1) continue; // Bỏ qua cột thứ k
                        newMatrix[i, newColIndex] = matrix1[i, j];
                        newColIndex++;
                    }
                }

                // Hiển thị ma trận sau khi xóa cột thứ k
                Console.WriteLine($"Ma trận sau khi xóa cột thứ {k}:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols - 1; j++)
                    {
                        Console.Write(newMatrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                // Tính trung bình các phần tử chẵn
                int sum = 0;
                int count = 0;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols - 1; j++)
                    {
                        if (newMatrix[i, j] % 2 == 0) 
                        {
                            sum += newMatrix[i, j];
                            count++;
                        }
                    }
                }

                // Hiển thị kết quả
                if (count > 0)
                {
                    double average = (double)sum / count;
                    Console.WriteLine($"Trung bình các phần tử chẵn trong ma trận là: {average}");
                }
                else
                {
                    Console.WriteLine("Không có phần tử chẵn trong ma trận.");
                }

            }

        }

    }
}
