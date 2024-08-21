using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders06_For5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girilen sayının tam bölenlerini bulma");

            int number = 0;
            int kacTaneBolen = 0;
            Console.WriteLine("Bir sayı giriniz:");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    kacTaneBolen++;
                }
            }
            Console.WriteLine("Tam bölen sayısı: " + kacTaneBolen);
            Console.ReadLine();
        }
    }
}
