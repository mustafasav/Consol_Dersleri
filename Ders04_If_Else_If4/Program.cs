using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders04_If_Else_If4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayının girilen başka sayıya tam bölünüp bölünmediği
            int number1, number2;
            Console.WriteLine("Birinci sayı giriniz:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayı giriniz:");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 % number2 == 0)
            {
                Console.WriteLine(number1 + " sayısı " + number2 + " sayısına tam bölünür.");
            }
            else
            {
                Console.WriteLine(number1 + " sayısı " + number2 + " sayısına tam bölünmez.");
            }

            Console.Read();
        }
    }
}
