using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders05_Switch_Case3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen şehirlerin Yozgat'a uzaklıklarını yazan bir örnek...

            string city;
            Console.WriteLine("Ankara - İstanbul - İzmir - Afyon - Trabzon");
            Console.WriteLine("Lütfen şehir ismi giriniz:");
            city = Console.ReadLine().ToLower();

            switch (city)
            {
                case "ankara":
                    Console.WriteLine("Yozgat'ın " + city + " şehrine uzaklığı 250 KM");
                    break;
                case "istanbul":
                    Console.WriteLine("Yozgat'ın " + city + " şehrine uzaklığı 800 KM");
                    break;
                case "izmir":
                    Console.WriteLine("Yozgat'ın " + city + " şehrine uzaklığı 700 KM");
                    break;
                case "afyon":
                    Console.WriteLine("Yozgat'ın " + city + " şehrine uzaklığı 600 KM");
                    break;
                case "trabzon":
                    Console.WriteLine("Yozgat'ın " + city + " şehrine uzaklığı 850 KM");
                    break;
                default:
                    Console.WriteLine("Hatalı şehir adı girişi...");
                    break;
            }

            Console.ReadLine();
        }
    }
}
