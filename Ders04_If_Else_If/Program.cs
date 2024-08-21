using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders04_If_Else_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sinav1, sinav2, proje, ortalama;
            Console.Write("1. Sınav Notunu Gir: ");
            sinav1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sınav Notunu Gir: ");
            sinav2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Proje Notunu Gir: ");
            proje = Convert.ToInt32(Console.ReadLine());
            ortalama = (sinav1 + sinav2 + proje) / 3;

            Console.WriteLine("Ortalama: " + ortalama);
            // && --> and 
            //


            if (ortalama > 0 && ortalama < 30)
            {
                Console.WriteLine("Durum: Çok Kötü");
            }
            else if (ortalama >= 30 && ortalama < 50)
            {
                Console.WriteLine("Durum: İyi Değil");
            }
            else if (ortalama >= 50 && ortalama < 75)
            {
                Console.WriteLine("Durum: İyi");
            }
            else
            {
                Console.WriteLine("Durum: Süper");
            }


            Console.Read();
        }
    }
}
