using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Z.M.CAVDAR";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Engin Demirog";
            kurs2.IzlenmeOrani = 55;


            Console.WriteLine("Kurs Adi: "+ kurs1.KursAdi + " Kurs Egitmeni: " + kurs1.Egitmen);


            Console.WriteLine("dizi class tanimlama");
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2}; //Kurs arrayi tanimlama


            foreach (var kurs in kurslar)
            {

               Console.WriteLine("Kurs Adi: " + kurs.KursAdi + " Kurs Egitmeni: " + kurs.Egitmen);

            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
