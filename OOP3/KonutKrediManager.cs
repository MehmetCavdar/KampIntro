using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager   // Inheritance  yalniz Interface ile  
    //Ikredimanager üzeine gelince lamba isreti cikinca  implement tiklaninca interface yapilan klasstaki ortak public yapisi cikiyor
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme Plani Hesaplandi");
        }
    }
}
