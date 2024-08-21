using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders02_Degiskenler_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tÖğrenci Not Hesaplama");
            double sinav1, sinav2, sinav3, proje, ortalama;
            string ad, soyad, numara;

            Console.Write("Adınızı giriniz:");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı giriniz:");
            soyad = Console.ReadLine();
            Console.Write("Numaranızı giriniz:");
            numara = Console.ReadLine();

            Console.Write("1. Sınav Notunu giriniz:");
            sinav1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Sınav Notunu giriniz:");
            sinav2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("3. Sınav Notunu giriniz:");
            sinav3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Proje Notunu giriniz:");
            proje = Convert.ToDouble(Console.ReadLine());

            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            Console.WriteLine("{2} - {0} {1} ", ad, soyad, numara);
            Console.WriteLine("Ortalaman : {0} ", ortalama);
            Console.ReadLine();
        }
    }
}
