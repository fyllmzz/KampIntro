using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
          //  ıhtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
           // tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();



            ILoggerService databaseLoggerService = new DatabaseLoggerService();//loglama
            ILoggerService fileLoggerService = new FileLoggerService();

            IKrediManager esnafKrediManager = new EsnafKredisiManager();
            ILoggerService smsLoggerService = new SmsLoggerService();


            List<ILoggerService> logger = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,
                new List<ILoggerService> { new DatabaseLoggerService(),new SmsLoggerService()});//2 tane loglama var ben database seçtim
            //basvuruManager.BasvuruYap(konutKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            basvuruManager.BasvuruYap(esnafKrediManager, logger);


            List<IKrediManager> krediler = new List<IKrediManager> { ihtiyacKrediManager ,tasitKrediManager};
          //  basvuruManager.KrediOnbilgilendirmesiYap(krediler);






        }
    }
}
