using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_14
{
    internal class Program
    {
        public static double Swap(out int a, out int b)
        {
            a = 5;
            b = 10;
            int temp = a; 
            a = b;
            b = temp;
            return (a + b) / 2.0;
        }
        static void Main(string[] args)
        {
            int x, y;
            double average = Swap(out x, out y);
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Sau khi hoán đổi: x = {x}, y = {y}");
            Console.WriteLine($"Giá trị trung bình của x và y: {average}");
        }
    }
}
