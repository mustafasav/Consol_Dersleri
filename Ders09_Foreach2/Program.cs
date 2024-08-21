using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders09_Foreach2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 15, 25, 33, 45, 56, 75 };
            int total = 0;

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                total += number;

            }
            Console.WriteLine("Toplam : " + total);
            Console.Read();
        }
    }
}
