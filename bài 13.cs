using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 2, 7, 10, 1 };
            ref int maxRef = ref FindMaxRef(arr);
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Giá trị lớn nhất: " + maxRef);
            maxRef = 100;
            Console.WriteLine("Mảng sau khi thay đổi giá trị lớn nhất: " + string.Join(", ", arr));
        }
        static ref int FindMaxRef(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Mảng không được rỗng");
            }
            ref int maxRef = ref array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxRef)
                {
                    maxRef = ref array[i];
                }
            }
            return ref maxRef;
        }
    }
}
