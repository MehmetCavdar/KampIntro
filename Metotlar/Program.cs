using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class örengi olusturma
            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            //Class örengi olusturma
            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (var urun in urunler) // var degisik tipte olur
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
  
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("----------METODLAR-------------"); //kisayolu cw yazip 2xTab

            //Instance(Class örnegi olusturma)
            SepetManager sepetManager = new SepetManager();

            foreach (var urun in urunler) // var degisik tipte olur
            {
                sepetManager.Ekle(urun);  //Class cagirma
            }

            sepetManager.Ekle2("Armut", "Yesil Armut", 12);


        }
    }
}



// 3.ders
//DRY_ Do not repeat yourself
//Github hesabu actik ve git adli programi bilgisayara kurduk


//METODLAR ve CLASSLAR
//Metotlar tekrar kullanilabilirligi saglayan kod bloklari
// Sag trafta solution explorer kisminda metotolarin üzerine sag tiklayip add (ekle) ile class ekleyelim
//prop yazip 2xtab tusuna basilirsa public fonksiyonu baslangin-bitis temel degerleri otomatik cikar

// dizi ve class vb. yapilarin adlari  degiskeni degil adresi hafizada tutar.
// O yüzden tanimlama yaparken  "Tip ad = new Tip []{}" seklinde tanimlama yapilir 
// classlari da dizi tipinda tanimlayabiliriz. asil isimize yarayacak olan budur. bir veri tabanindan verileri bu sekilde alabiliriz
//Degiskenler büyük harfle tanimlanir
// solution Explorer sayfasindaki  programlardan ilkini tanimlama
//  örengin metodlarin üzerinde saga tiklayip "Set a Startup Projekt" secilir
//
//
//
//
//
//
//
//
//
//
