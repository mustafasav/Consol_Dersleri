﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders06_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ekrana 10 defa merhaba yazdıran program

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Merhaba Dünya");
            }
            Console.ReadLine();
        }
    }
}
