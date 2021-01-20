using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product product1 = new Product(); //Class tanimlama
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Console.WriteLine(product1.ProductName);
            Console.WriteLine("------------------------------");

            Product product2 = new Product
            {
                Id = 2,
                ProductName = "Kalem",
                CategoryId = 5,
                UnitsInStock = 5,
                UnitPrice = 35
            };   //direkt klass tanimlama

            Console.WriteLine(product2.ProductName);
            Console.WriteLine("------------------------------");


            ProductManager productManager = new ProductManager();

            productManager.Add(product1);


            int sayi1;
            int sayi2;
            int toplam;

            sayi1 = 3;
            sayi2 = 6;
            toplam = productManager.Topla(sayi1, sayi2);
            Console.WriteLine("Toplam = " + toplam);
        }

        }
    } 
