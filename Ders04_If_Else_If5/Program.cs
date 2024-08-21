using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders04_If_Else_If5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen mevsime göre ayları gösterme
            string mevsim;
            Console.WriteLine("Bir mevsim giriniz:");
            mevsim = Console.ReadLine();
            mevsim = mevsim.ToLower();
            //toLower -> küçük harfe çevirme

            if (mevsim == "yaz")
            {
                Console.WriteLine("Haziran - Temmuz - Ağustos");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.WriteLine("Mart - Nisan - Mayıs");
            }
            else if (mevsim == "sonbahar")
            {
                Console.WriteLine("Eylül - Ekim - Kasım");
            }
            else if (mevsim == "kış")
            {
                Console.WriteLine("Aralık - Ocak - Şubat");
            }
            else
            {
                Console.WriteLine("Yanlış bir mevsim adı girildi.");
            }


            Console.ReadLine();
        }
    }
}
