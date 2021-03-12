using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            isimler.Add("Mehmet");

            Console.WriteLine(isimler.Length());
            
            isimler.Add("Recep");
            isimler.Add("Anıl");

            Console.WriteLine(isimler.Length());

            foreach (var isim in isimler.Items())
            {
                Console.WriteLine(isim);
            }
        }
    }
}
