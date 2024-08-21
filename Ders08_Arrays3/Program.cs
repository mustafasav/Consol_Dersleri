using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08_Arrays3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayıları diziye atarak en büyük ve en küçük bulma

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Sayı girin:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxValue;
            int minValue;
            maxValue = minValue = numbers[0];
            //En büyük ve en küçük değerleri bulurken ilk eleman her zaman
            //hem en büyük hem en küçük kabul edilir.

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
            }

            Console.WriteLine("En Büyük: " + maxValue);
            Console.WriteLine("En Küçük: " + minValue);
            Console.Read();
        }
    }
}
