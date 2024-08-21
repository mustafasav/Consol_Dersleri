using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders06_For3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - 10 arası sayıların toplamı");
            int toplam;
            toplam = 0;
            for (int i = 0; i <= 10; i++)
            {
                toplam += i;
                Console.WriteLine("Sayı: " + i + " -> Toplam : " + toplam);
            }


            Console.ReadLine();
        }
    }
}
