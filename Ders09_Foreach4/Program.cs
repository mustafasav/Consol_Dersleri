using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders09_Foreach4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizideki elemanların faktöriyellerini almak

            int[] numbers = { 5, 6, 12, 8, 3, 11, 7, 4, 0, 1 };
            int result = 1;

            foreach (int number in numbers)
            {
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                Console.WriteLine(number + " sayısının faktöriyeli: " + result);
                result = 1;

            }
            Console.Read();
        }
    }
}
