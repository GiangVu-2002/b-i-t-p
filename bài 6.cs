using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} là số chẵn.");
                }
                else
                {
                    Console.WriteLine($"{number} là số lẻ.");
                }
            }
            else
            {
                Console.WriteLine("Lỗi: Hãy nhập một số nguyên hợp lệ.");
            }
        }
    }
}
