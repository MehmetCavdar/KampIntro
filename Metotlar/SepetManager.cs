using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming convention---degisken isimlernin ilk harfi (bilesik kelimelerde tüm kelimelerin ilk harfi) büyük
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi:" + urun.Adi);
        }

        //bu sekilde de yazabilirdik. Ancak istenmeyen yöntemdir.
        //classta bir degisiklik olmasi durumunda ana programdaki tüm class islemlerinde degisikligi islemek zorunda kalirsin
        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler.Sepete 2. yöntemle Eklendi:" + urunAdi);
        }
    }
}


// bu program (manager, execute vs) islemleri yapmak icin kullanilir 