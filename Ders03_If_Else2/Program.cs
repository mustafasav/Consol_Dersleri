using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders03_If_Else2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city;
            Console.WriteLine("Türkiye'nin Başkenti Neresidir?");
            city = Console.ReadLine();

            if (city.ToUpper() == "ANKARA")
            {
                Console.WriteLine("Tebrikler...");
            }
            else
            {
                Console.WriteLine("Yanlış cevap....");
            }

            Console.ReadLine();
        }
    }
}
