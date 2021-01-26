using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> isimler = new Mylist<string>();
            isimler.Add("Engin");
            Console.WriteLine("Liste Uzunlugu :"+ isimler.Length);

            isimler.Add("Kerem");
            Console.WriteLine("Liste Uzunlugu: " + isimler.Length);

            foreach (var isim in isimler.Items)  // isimler dizisindeki tanimli eleman sayisi "isimler.items"dir
            {
                Console.WriteLine(isim);
            }

        }
    }
}
