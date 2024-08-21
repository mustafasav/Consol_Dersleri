using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders04_If_Else_If3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayının 5'e tam bölünüp bölünmediği
            int number;
            Console.WriteLine("Bir sayı giriniz:");
            number = Convert.ToInt32(Console.ReadLine());

            // % mod alma operatörü
            int kalan = number % 5;
            if (kalan == 0)
            {
                Console.WriteLine("Girilen sayı 5'e tam bölünür.");
            }
            else
            {
                Console.WriteLine("Girilen sayı 5'e tam bölünmez");
            }


            Console.Read();
        }
    }
}
