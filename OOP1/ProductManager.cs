﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // bir metottan dönen bir deger yoksa void yazilir 
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }




        public int Topla (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

    }
}
