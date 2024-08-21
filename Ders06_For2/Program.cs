using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders06_For2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1'den 10 a kadar sayıları yazdırma");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("1'den 10 a kadar tek sayıları yazdırma");
            for (int i = 1; i <= 10; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("1'den 10 a kadar çift sayıları yazdırma");
            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
