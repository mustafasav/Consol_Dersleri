using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders03_If_Else3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Bir sayı giriniz:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("Girilen sayı pozitif");

            }
            else
            {
                Console.WriteLine("Girilen sayı negatif...");
            }
            Console.ReadLine();
        }
    }
}
