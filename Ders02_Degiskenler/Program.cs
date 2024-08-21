using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String
            //string isim;
            //isim = "Mustafa SAV";
            //Console.WriteLine(isim);
            //string memleket = "Afyonkarahisar";
            //Console.WriteLine(memleket);
            //string name;
            //Console.Write("İsminizi giriniz: ");
            //name = Console.ReadLine();
            //Console.WriteLine("Hoşgeldiniz " + name);

            //string ad, soyad,yas,meslek,sehir;
            //Console.Write("Adınızı girin: ");
            //ad = Console.ReadLine();
            //Console.Write("Soyadınızı girin: ");
            //soyad = Console.ReadLine();
            //Console.Write("Yaşınızı girin: ");
            //yas = Console.ReadLine();
            //Console.Write("Mesleğinizi girin: ");
            //meslek = Console.ReadLine();
            //Console.Write("Şehrinizi girin: ");
            //sehir = Console.ReadLine();

            //Console.WriteLine("Ad: " + ad);
            //Console.WriteLine("Soyad: " + soyad);
            //Console.WriteLine("Yaş: " + yas);
            //Console.WriteLine("Meslek: " + meslek);
            //Console.WriteLine("Şehir: " + sehir);

            //Console.WriteLine("Ad:{0}\nSoyad:{1}\nYaş:{2}\nMeslek:{3}\nŞehir:{4}", ad,soyad,yas,meslek,sehir);
            // Console.WriteLine("Ad:{4} - Soyad:{3} - Yaş:{2} - Meslek:{1} - Şehir:{0}", ad, soyad, yas, meslek, sehir);
            //Console.WriteLine("Ad:{0} - Soyad:{2} - Yaş:{1} - Meslek:{3} - Şehir:{4}", ad, yas, soyad, meslek, sehir);

            int birinciSayi, ikinciSayi, toplam;
            Console.Write("Birinci Sayıyı Giriniz: ");
            birinciSayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            ikinciSayi = Convert.ToInt32(Console.ReadLine());
            toplam = birinciSayi + ikinciSayi;
            Console.WriteLine("Girilen {0} ve {1} sayısının toplamı: {2}", birinciSayi, ikinciSayi, toplam);
            Console.WriteLine("Girilen {0} ve {1} sayısının farkı: {2}", birinciSayi, ikinciSayi, birinciSayi - ikinciSayi);
            Console.WriteLine("Girilen {0} ve {1} sayısının çarpımı: {2}", birinciSayi, ikinciSayi, birinciSayi * ikinciSayi);
            Console.WriteLine("Girilen {0} ve {1} sayısının bölümü: {2}", birinciSayi, ikinciSayi, birinciSayi / ikinciSayi);
            Console.Read();
        }
    }
}
