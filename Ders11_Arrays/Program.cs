using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Sort ve Array Reverse 

            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Bir sayı girin: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers); // dizi elemanlarını küçükten büyüğe sıralama

            //Dizinin en büyük elemanını dizinin kapasitesini bilmeden bulma
            Console.WriteLine("En büyük eleman: " + numbers[numbers.Length - 1]);
            //Length: Dizi uzunluğu
            //Count: Dizi eleman sayısı

            //Eğer dizinin tüm indexleri doluysa ikisi de kullanılabilir
            //Dizinin tüm indexleri dolu değilse length boşları da getirir.
            //Count ise girilen değerler kadarını getirir.
            //boyutu 10 olan bir diziye 5 tane sayı girildiğini düşünelim
            //length ile döndürürsek 10 sonucu elde ederiz.
            //count ile döndürürsek 5 sonucunu elde ederiz.
            Console.WriteLine("En büyük eleman: " + numbers[numbers.Count() - 1]);
            Console.WriteLine();
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Array.Reverse(numbers); //Diziyi tersine çevirme
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }


            Console.Read();
        }
    }
}
