using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        //Method Injection burada basvuru anında hangi kredi türü, hangi loglama ile ilgli bilgi yok. Soyut şeklinde gönderdik
        public void BasvuruYap(IKrediManager krediManager,List< ILoggerService> loggerService )
        {

            //Basvuran bilgilerini degerlendirme
            //
            //YANLIS WAY
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            
            krediManager.Hesapla();
            //loggerService.Log(); tekli loglama sistemi. Metoda ILoggerService loggerService parametre gecilir. 
            //hem veritabaınan logla, hem sms logla bundan dolayı list kullanılır
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
