using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders04_If_Else_If6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir satıcının 100 liraya kadar % 10
            // 100 - 150 arası % 15
            // 150'den fazlası için % 20 indirim yaptığı bir uygulama

            double tutar = 0, indirim = 0, odenecekTutar = 0;
            Console.WriteLine("Alışveriş miktarını giriniz:");
            tutar = Convert.ToDouble(Console.ReadLine());

            if (tutar > 0 && tutar <= 100)
            {
                indirim = tutar * 10 / 100;
            }
            else if (tutar > 100 && tutar < 150)
            {
                indirim = tutar * 15 / 100;
            }
            else
            {
                indirim = tutar * 20 / 100;
            }

            odenecekTutar = tutar - indirim;

            Console.WriteLine("Ödenecek Tutar: " + Convert.ToString(odenecekTutar));
            Console.ReadLine();
        }
    }
}
