using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders09_Foreach3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir dizideki elemanlardan girilen sayıya tam bölünenleri alma...

            int[] numbers = { 1, 25, 36, 45, 32, 65, 66, 98, 97, 65, 64 };
            int enterNumber = 0;
            Console.WriteLine("Bir sayı girin:");
            enterNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dizi içinde " + enterNumber + " sayısına tam bölünenler:");
            foreach (int number in numbers)
            {
                if (number % enterNumber == 0)
                {
                    Console.WriteLine(number);
                }
            }
            Console.Read();
        }
    }
}
