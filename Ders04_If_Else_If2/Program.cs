using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders04_If_Else_If2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayının tek mi çift mi olduğunu bulan program
            int number;
            Console.WriteLine("Bir sayı giriniz:");
            number = Convert.ToInt32(Console.ReadLine());

            // % mod alma operatörü
            int kalan = number % 2;
            if (kalan == 0)
            {
                Console.WriteLine("Sayı Çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı Tektir.");
            }


            Console.Read();
        }
    }
}
