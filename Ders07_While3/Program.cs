using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders07_While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faktöriyel hesaplama
            int girilenSayi, sayac = 1, sonuc = 1;
            Console.WriteLine("Faktöriyel hesaplanacak sayıyı girin:");
            girilenSayi = Convert.ToInt32(Console.ReadLine());

            while (sayac <= girilenSayi)
            {
                sonuc *= sayac;
                sayac++;

            }

            Console.WriteLine(girilenSayi + " sayısının faktöriyeli: " + sonuc);

            Console.ReadLine();
        }
    }
}
