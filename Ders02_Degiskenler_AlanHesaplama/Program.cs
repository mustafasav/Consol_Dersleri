using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders02_Degiskenler_AlanHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kenar, cevre, alan;
            Console.WriteLine("Karenin Alanını Bulma");
            Console.Write("Karenin kenar uzunluğunu girin:");
            kenar = Convert.ToInt32(Console.ReadLine());
            cevre = 4 * kenar;
            alan = kenar * kenar;
            Console.WriteLine("Sonuçlar");
            Console.WriteLine("Karenin Alanı: " + alan);
            Console.WriteLine("Karenin Çevresi: " + cevre);
            Console.Read();
        }
    }
}
