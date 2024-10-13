using System.Text.RegularExpressions;

namespace BTVN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding=System.Text.Encoding.UTF8;
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            // 1. Nhập vào một xâu ký tự và hiển thị xâu đó ra màn hình
            Console.Write("Nhập vào một xâu ký tự:");
            string inputString = Console.ReadLine();
            Console.WriteLine("Xâu ký tự vừa nhập: " + inputString);

            // 2. Đếm số lượng chữ thường và chữ hoa trong xâu
            int lowerCaseCount = 0;
            int upperCaseCount = 0;

            foreach (char c in inputString)
            {
                if (char.IsLower(c))
                    lowerCaseCount++;
                else if (char.IsUpper(c))
                    upperCaseCount++;
            }
            Console.WriteLine($"Số lượng chữ thường: {lowerCaseCount}");
            Console.WriteLine($"Số lượng chữ hoa: {upperCaseCount}");

            // 3. Đếm số từ trong xâu vừa nhập
            int wordCount = inputString.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Số từ trong xâu vừa nhập: {wordCount}");

            // 4. Đếm số phụ âm và nguyên âm trong xâu vừa nhập
            int vowelCount = 0;
            int consonantCount = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in inputString)
            {
                if (char.IsLetter(c))
                {
                    if (vowels.Contains(c))
                        vowelCount++;
                    else
                        consonantCount++;
                }
            }
            Console.WriteLine($"Số nguyên âm: {vowelCount}");
            Console.WriteLine($"Số phụ âm: {consonantCount}");

            // 5. Nhập vào một xâu con và đếm số lần xuất hiện của xâu con trong xâu đã nhập
            Console.Write("Nhập vào một xâu con:");
            string subString = Console.ReadLine();

            // Sử dụng Regex để đếm số lần xuất hiện của xâu con
            int subStringCount = Regex.Matches(inputString, Regex.Escape(subString)).Count;
            Console.WriteLine($"Số lần xuất hiện của xâu con '{subString}' trong xâu vừa nhập: {subStringCount}");
        }
    }
}
