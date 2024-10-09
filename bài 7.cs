using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số: ");
            string input = Console.ReadLine();
            int number;
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Lỗi: Bạn phải nhập một số nguyên.");
                return;
            }
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{number} không phải là số nguyên tố.");
            }
        }

        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false; 
            }
            return true;
        }
    }
}

