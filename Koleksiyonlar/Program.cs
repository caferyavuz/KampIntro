using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            Console.WriteLine("----------------------------------");

            List<string> isimler2 = new List<string> {"Engin","Murat" };
            isimler2.Add("Mehmet");

            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
