using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders06_For6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Serisi ilk 10 eleman");
            int number1 = 1;
            int number2 = 1;
            int number3;
            Console.Write(number1 + " ");
            Console.Write(number2 + " ");
            for (int i = 0; i < 10; i++)
            {
                number3 = number1 + number2;
                Console.Write(number3 + " ");
                number1 = number2;
                number2 = number3;

            }


            Console.ReadLine();
        }
    }
}
