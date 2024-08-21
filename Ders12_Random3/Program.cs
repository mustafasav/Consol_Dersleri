using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Random3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Milli Piyango Çekilişi...");
            Random random = new Random();
            int secilenRakam;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Seçilen " + (i + 1) + ". Bilet No: ");

                for (int k = 0; k < 7; k++)
                {
                    secilenRakam = random.Next(0, 10);
                    Console.Write(secilenRakam + "");
                }
                Console.WriteLine();
            }







            Console.Read();
        }
    }
}
