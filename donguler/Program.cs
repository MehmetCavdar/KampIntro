using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] kurslar = new string[] {"kurs1","kurs2"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine("foreach ile yazilan: " + kurs);
            }


     

            Console.WriteLine("tekli artirma");
            for (int i = 1; i < 5; i ++)
            {
                Console.WriteLine("deger:"+ i);
            }

            Console.WriteLine("ikili artirma");
            for (int i = 6; i <10; i+=2)
            {
                Console.WriteLine("ikili deger:" + i);
            }
        }
    }
}
