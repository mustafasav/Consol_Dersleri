using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders05_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayının haftanın ilgili gününü veren
            // 1-> Pazartesi .... 7-> Pazar gibi

            int dayNumber;
            Console.WriteLine("1-7 arasında bir sayı giriniz:");
            dayNumber = Convert.ToInt16(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş...");
                    break;

            }
            Console.ReadLine();

        }
    }
}
