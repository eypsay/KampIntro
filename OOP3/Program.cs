using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            ILoggerService fileLoggerService = new FileLoggerService(); 



            BasvuruManager basvuruManager = new BasvuruManager();
          // basvuruManager.BasvuruYap(tasitKrediManager, new DatabaseLoggerService());
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> {new DatabaseLoggerService(),new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
