using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //Topla(2,3) metodu cagirma sekli  2 sayi1 degiskenine, 3 sayi 2 degiskenine atanir
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            
            Console.WriteLine(sayi1 +  " + " + sayi2 + " = " + toplam);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine(sayi1 + " * " + sayi2 + " = " + carpim);
        }

    }
}
