using System;

namespace OOP3
{
    class SmsLoggerService : ILoggerService   // Interface yaptik
    {
        public void Log()  // burada bu metod icin komutu yaziyoruz
        {
            Console.WriteLine("SMS Yollandi");
        }
    }
}
