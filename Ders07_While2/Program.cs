using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders07_While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan sıfır girilene kadar sayı isteyen program
            int girilenSayi;
            Console.WriteLine("Bir sayı girin");
            girilenSayi = Convert.ToInt32(Console.ReadLine());

            while (girilenSayi != 0)
            {
                Console.WriteLine("Bir sayı girin");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sıfır girdiniz. Program sonlanacak.");
            Console.ReadLine();
        }
    }
}
