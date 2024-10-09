using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 1, 2 };
            bool swapped;
            int n = numbers.Length;

            do
            {
                swapped = false;
                int i = 0;

                while (i < n - 1)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        swapped = true;
                    }
                    i++;
                }
                n--; 
            } while (swapped); 
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine(); 

            swapped = true;
            n = numbers.Length; 

            do
            {
                swapped = false;
                int i = 0;

                while (i < n - 1)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                       
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        swapped = true;
                    }
                    i++;
                }
                n--;
            } while (swapped);

            Console.WriteLine("Mảng sau khi sắp xếp giảm dần:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
               
            }
        }
    }
}
