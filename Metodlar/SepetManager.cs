﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete "+urun.Adi+" eklendi");
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat)
        {
            Console.WriteLine("Sepete " + urunAdi + " eklendi");
        }
    }
}
