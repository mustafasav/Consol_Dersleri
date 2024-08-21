using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizilere Giriş
            //DeğişkenTürü[] Değişkenİsmi = {Değerler}
            int[] numbers = { 14, 22, 51, 68, 75, 10, 20 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[5]);

            string[] names = { "Ahmet", "Mustafa", "Serkan", "Emine", "Deniz" };

            Console.WriteLine(names[2]);

            Console.Read();
        }
    }
}
