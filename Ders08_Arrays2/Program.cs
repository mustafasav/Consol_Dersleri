using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08_Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değerler sonradan girilecek kapasitesi belli dizi tanımlama
            string[] sehirler = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Şehir: ");
                sehirler[i] = Console.ReadLine();
            }
            Console.WriteLine("...Şehirler Listesi...");
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }

            Console.Read();
        }
    }
}
