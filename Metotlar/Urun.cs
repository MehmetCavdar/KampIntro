using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class Urun
    {
        public  int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }  
        // Bu degiskenin diger programlarda refere edilme sayisi belirtilir (3 references)


    }
}


//prop yazip 2xtab tusuna basilirsa public fonksiyonu baslangin-bitis temel degerleri otomatik cikar