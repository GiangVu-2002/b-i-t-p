using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baif_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên (0 - 9999): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number) || number < 0 || number > 9999)
            {
                Console.WriteLine("Hãy nhập số");
                return;
            }

            string numberInWords = ConvertNumberToWords(number);
            Console.WriteLine("Thành chữ: " + numberInWords);
        }

        static string ConvertNumberToWords(int number)
        {
            if (number == 0)
                return "không";

            string[] unitsMap = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] tensMap = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            string[] hundredsMap = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
            string[] thousandsMap = { "", "một nghìn", "hai nghìn", "ba nghìn", "bốn nghìn", "năm nghìn", "sáu nghìn", "bảy nghìn", "tám nghìn", "chín nghìn" };

            string words = "";

            int[] numberParts = { number / 1000, (number / 100) % 10, (number / 10) % 10, number % 10 };
            for (int i = 0; i < numberParts.Length; i++)
            {
                if (numberParts[i] > 0)
                {
                    switch (i)
                    {
                        case 0:
                            words += thousandsMap[numberParts[i]] + " ";
                            break;
                        case 1:
                            words += hundredsMap[numberParts[i]] + " ";
                            break;
                        case 2:
                            words += tensMap[numberParts[i]] + " ";
                            break;
                        case 3:
                            words += unitsMap[numberParts[i]] + " ";
                            break;
                    }
                }
            }

            return words.Trim();
        }
    }
}
