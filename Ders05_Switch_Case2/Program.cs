using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders05_Switch_Case2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen mevsime göre ayları yazdırma...

            string mevsim;
            Console.WriteLine("Mevsim adını girin:");
            mevsim = Console.ReadLine().ToLower();

            switch (mevsim)
            {
                case "yaz":
                    Console.WriteLine("Haziran - Temmuz - Ağustos");
                    break;
                case "ilkbahar":
                    Console.WriteLine("Mart - Nisan - Mayıs");
                    break;
                case "kış":
                    Console.WriteLine("Aralık - Ocak - Şubat");
                    break;
                case "sonbahar":
                    Console.WriteLine("Eylül - Ekim - Kasım");
                    break;
                default:
                    Console.WriteLine("Geçersiz mevsim adı");
                    break;
            }


            Console.ReadLine();
        }
    }
}
