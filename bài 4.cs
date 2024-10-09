using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bài_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số: ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"[^\d]"))
            {
                Console.WriteLine("Lỗi: không phải là số.");
            }
            else if (int.TryParse(input, out int number) && number >= 0)
            {
                long factorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Giai thừa của {number} là: {factorial}");
            }
            else
            {
                Console.WriteLine("Đầu vào không hợp lệ. Hãy nhập một số nguyên dương.");
                Console.ReadKey();
            }
        }
    }
}
