using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders05_Switch_Case4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen şehirlerin Yozgat'a uzaklıklarını yazan bir örnek...
            //Switch Case 3 örneğinin farklı yazılmış hali

            string city;
            int mesafe = 0;
            Console.WriteLine("Ankara - İstanbul - İzmir - Afyon - Trabzon");
            Console.WriteLine("Lütfen şehir ismi giriniz:");
            city = Console.ReadLine().ToLower();

            switch (city)
            {
                case "ankara":
                    mesafe = 500;
                    break;
                case "istanbul":
                    mesafe = 800;
                    break;
                case "izmir":
                    mesafe = 700;
                    break;
                case "afyon":
                    mesafe = 600;
                    break;
                case "trabzon":
                    mesafe = 850;
                    break;
                default:
                    Console.WriteLine("Hatalı şehir adı girişi...");
                    break;
            }

            if (mesafe != 0)
            {
                Console.WriteLine("Yozgat'ın " + city + " şehrine uzaklığı " + mesafe + " KM");
            }

            Console.ReadLine();
        }
    }
}
