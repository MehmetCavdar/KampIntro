using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager  // Inheritance  yalniz Interface ile  
    //Ikredimanager üzeine gelince lamba isreti cikinca  implement tiklaninca sagi interface yapilan klasstaki ortakdaki public yapisi cikiyor
    {
        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac kredisi ödeme Plani Hesaplandi");
        }
    }
}
