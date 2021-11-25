using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService>loggerServices)
        {
            //Başvuran bilgileri değerlendirme
            krediManager.Hesapla();

            //loggerService.Log(); //hangi logger servise gelmişse onu logla
            foreach (var logger in loggerServices)
            {
                logger.Log();
            }


        }
        public void KrediOnbilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
