using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mảng trước khi thay đổi:");
            PrintArray(numbers);
            ChangeArrayValue(ref numbers[1], 10);
            Console.WriteLine("Mảng sau khi thay đổi:");
            PrintArray(numbers);
        }
        static void ChangeArrayValue(ref int element, int newValue)
        {
            element = newValue;
        }
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
