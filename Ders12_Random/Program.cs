using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0 ile 10 arası bir sayı oluşturmak
            Random random = new Random();
            int sayi;
            sayi = random.Next(0, 10); //min - max arası sayı üretmek
            Console.WriteLine(sayi);


            int sayi1, sayi2;
            sayi1 = random.Next(0, 10);
            sayi2 = random.Next(0, 10);
            Console.WriteLine(sayi1 + " " + sayi2);

            int sayi3 = random.Next(50); //0 - 50 arası sayı üretmek
            Console.WriteLine(sayi3);

            //Parantez içi boş bırakılırsa tanımlanan sayı türünün aralığında değer getirir.
            double sayi4 = random.Next();
            Console.WriteLine(sayi4);
            float sayi5 = random.Next();
            Console.WriteLine(sayi5);



            Console.Read();
        }
    }
}
