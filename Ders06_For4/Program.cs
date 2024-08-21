using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders06_For4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - 100 arası 9 a tam bölünen sayıları bulma");
            for (int i = 0; i < 100; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
