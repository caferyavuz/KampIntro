﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerServices = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,smsLoggerServices);
            //basvuruManager.BasvuruYap(tasitKrediManager,new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>(){tasitKrediManager,konutKrediManager};
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
