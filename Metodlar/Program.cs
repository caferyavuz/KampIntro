using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1= new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyat = 6.5;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 12.5;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id+" : "+urun.Adi+" : "+urun.Fiyat+" : "+urun.Aciklama);
                Console.WriteLine("---------------------------------------------------------");
            }

            Console.WriteLine("-------------------------Metodlar-----------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut",12);
        }
    }
}
