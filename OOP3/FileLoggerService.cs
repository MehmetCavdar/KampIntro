using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService   // Interface yaptik
    {
        public void Log()  // burada bu metod icin komutu yaziyoruz
        {
            Console.WriteLine("Dosyaya Loglandi");
        }
    }
}
