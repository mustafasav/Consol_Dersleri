using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders03_If_Else4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int dersNotu;
            Console.WriteLine("Lütfen adınızı giriniz:");
            name = Console.ReadLine();
            Console.WriteLine("Lütfen ders notunuzu giriniz:");
            dersNotu = Convert.ToInt32(Console.ReadLine());

            if (dersNotu >= 50)
            {
                Console.WriteLine("Tebrikler " + name + " dersi geçtiniz");
            }
            else
            {
                Console.WriteLine("Üzgünüm " + name + " dersi geçemediniz.");
            }

            Console.ReadLine();
        }
    }
}
