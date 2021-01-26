using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //*****************Konu ADI fgjjbhjhjf : INTERFACE*****************

            //her tipte bir degisken tanimlandi
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKredisiManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            // ortak bir operasyon klassi tanimlandi
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager, new List<ILoggerService>{new DataBaseLoggerService(), new SmsLoggerService(), new FileLoggerService ()});
  

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
