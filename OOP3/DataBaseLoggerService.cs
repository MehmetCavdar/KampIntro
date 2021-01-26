using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DataBaseLoggerService: ILoggerService   // Interface yaptik
    {
        public void Log()  // burada bu metod icin komutu yaziyoruz
            {
            Console.WriteLine("Veritabanina Loglandi");
            }
    }
}
