using System;
using System.Collections.Generic;
namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> isimler = new MyList<string>();
            //isimler.Add("Engin");
            //isimler.Add("Mehmet");

            //Console.WriteLine(isimler.Count);

            //isimler.Add("Recep");
            //isimler.Add("Anıl");

            //Console.WriteLine(isimler.Count);

            //foreach (var isim in isimler.Items())
            //{
            //    Console.WriteLine(isim);
            //}

            Dictionary<int, string> isimler = new Dictionary<int, string>();
            isimler.Add(1,"semih");
            Console.WriteLine(isimler.Count);

            foreach (var item in isimler)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            Console.WriteLine("---------------------------------------------");

            MyDictionary<int, string> name = new MyDictionary<int, string>();
            Console.WriteLine(name.Count);
            name.Add(1,"mahmut");
            Console.WriteLine(name.Count);
            name.Add(1, "mahmut");
            Console.WriteLine(name.Count);

        }
    }
}
