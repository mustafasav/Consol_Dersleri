using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders07_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ekrana mesaj yazdıran program");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i + " Merhaba Yozgat");
                i++;
            }

            int j = 1;
            Console.WriteLine("1-10 arası sayıları yazdırma");
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }


            Console.ReadLine();
        }
    }
}
