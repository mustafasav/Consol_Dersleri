using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders09_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Mersin", "İstanbul", "Afyon", "Yozgat", "Samsun", "Erzurum", "Hakkari" };

            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            Console.Read();
        }
    }
}
