using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class Mylist <T>  // T belirlenen bir Tip olacak 
    {
        T[] items;
        public Mylist()  //ctor 2xtab asagidaki "Constructor" yapisini getirir. 
        {
            items = new T[0];   // bu komutla klass hemen calismaya baslar ve 0 elemanli bir dizi olusur
        }
        
        public void Add (T item) // burada bir diziye ekleme yapiyoruz
        {
            T[] tempArray = items;  // gecici dizinin referansini itemin referansina atadim ki kaybolmasin
            
            //burada yeni bir referans numarasiyla eleman sayisi 1 fazla liste olustu        
            items = new T[items.Length +1]; //items listesinin genisligini +1 yapiyorum (1 artiriyorum)
            // eskiden var olan elemanlari  eleman sayisi 1 artmis olan yeni diziye aliyoruz
            for(int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }   
            items[items.Length - 1] = item; // simdi listenin en sonuna istenen bilgiyi ekliyoruz
        }

        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
