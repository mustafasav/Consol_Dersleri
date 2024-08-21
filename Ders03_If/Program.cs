using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders03_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim;
            isim = "mustafa";

            if (isim == "mustafa")
            {
                Console.WriteLine("Doğru isim girişi");
            }
            else
            {
                Console.WriteLine("Yanlış isim girişi");
            }
            Console.Read();
        }
    }
}
