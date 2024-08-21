using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08_Arrays4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 3 adet öğrenci adını - 1. sınav ve 2. sınav notunu dizide tutup
            //ortalasını hesaplayan program. (dizilerle tutulacak)
            string[] names = new string[3];
            int[] exam1 = new int[3];
            int[] exam2 = new int[3];
            double[] average = new double[3];
            //ortalama ondalıklı çıkabilir.

            for (int i = 0; i < names.Length; i++)
            {
                Console.OutputEncoding = Encoding.GetEncoding("ibm857");//Consolde Türkçe karakter sorunu olmasın diye
                Console.Clear(); //Consol ekranını temizler
                Console.Write(i + 1 + ". Öğrencinin Adını Giriniz:");
                names[i] = Console.ReadLine();
                Console.Write(names[i] + " isimli öğrencinin 1. Sınav Notunu Giriniz:");
                exam1[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write(names[i] + " isimli öğrencinin 2. Sınav Notunu Giriniz:");
                exam2[i] = Convert.ToInt32(Console.ReadLine());
                average[i] = (Convert.ToDouble(exam1[i]) + Convert.ToDouble(exam2[i])) / 2;
            }
            Console.WriteLine("Sonuçlar...");

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " isimli öğrencinin notları " + exam1[i] + " - " + exam2[i] + " ve ortalaması " + average[i]);
            }
            Console.Read();

        }
    }
}
