using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
    {
        public void Hesapla() // Inheritance  yalniz Interface ile  
         //Ikredimanager üzeine gelince lamba isreti cikinca  implement tiklaninca interface yapilan klasstaki ortak public yapisi cikiyor

        {
            Console.WriteLine("tasit kredisi ödeme Plani Hesaplandi");
        }
    }
}
