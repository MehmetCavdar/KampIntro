using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
            // burada degiskeni bu sekilde tanimlarsak tüm krediler icin kullanabileccegimiz bir metod olur
        {

            krediManager.Hesapla();  // buraya hangi tip kredi gelirse onun hesapla metodu calisir
            foreach (var loggerService in loggerServices)
            {
            loggerService.Log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)   //belirsiz sayida kredi talebi olabilir
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla ();
            }

        }
    }
}
