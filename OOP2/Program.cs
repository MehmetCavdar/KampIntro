using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //*****************Konu ADI  : HERITANCE*****************

            GercekMusteri musteri1 = new GercekMusteri();   

            musteri1.Id = 1;  //ebeveyn klass degiskeni
            musteri1.MusteriNo = "121323"; //ebeveyn klass degiskeni
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "1234545566666";


            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 2;//ebeveyn klass degiskeni
            musteri2.MusteriNo = "Engin"; //ebeveyn klass degiskeni
            musteri2.SirketAdi = "Demirog";
            musteri2.VergiNo = "1234545566666";


            Musteri musteri3 = new GercekMusteri();  // dikkat!!!! sol taraf Ebeveyn klass seklinde
            Musteri musteri4 = new TuzelMusteri();  // dikkat!!!! sol taraf Ebveyn klass seklinde


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle (musteri3); // buraya ebeveyn klass sekliinde deiger 2 klass elemani gönderebiliriz
            musteriManager.Ekle(musteri4);

        }
    }
}
