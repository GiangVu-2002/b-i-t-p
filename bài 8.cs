using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mangSo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> soChan = new List<int>();
            List<int> soLe = new List<int>();

            foreach (int num in mangSo)
            {
                if (num % 2 == 0)
                    soChan.Add(num);
                else
                    soLe.Add(num);
            }
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mảng số chẵn: " + string.Join(", ", soChan));
            Console.WriteLine("Mảng số lẻ: " + string.Join(", ", soLe));
        }
    }
}
