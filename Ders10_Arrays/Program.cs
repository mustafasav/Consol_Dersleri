using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizideki pozitif ve tek sayıları listeleme
            int[] numbers = { 5, 12, -5, -13, 26, 32, -1, 0, 5, 6, 9, -7, 16 };

            foreach (int number in numbers)
            {
                if (number >= 0 && number % 2 == 1)
                {
                    Console.Write(number + " ");
                }
            }
            // Number dizisindeki 10 ile 30 arasında 4 e tam bölünenler
            Console.WriteLine();

            foreach (int number in numbers)
            {
                if (number >= 10 && number % 4 == 0 && number <= 30)
                {
                    Console.Write(number + " ");
                }
            }
            Console.Read();
        }
    }
}
