using System;
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
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            //List<ILoggerService> loggerService = new List<ILoggerService>() {databaseLoggerService,smsLoggerService };
            basvuruManager.BasvuruYap(esnafKrediManager,new List<ILoggerService>() {new DatabaseLoggerService(),new SmsLoggerService()});
            //basvuruManager.BasvuruYap(tasitKrediManager,new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>(){tasitKrediManager,konutKrediManager};
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
