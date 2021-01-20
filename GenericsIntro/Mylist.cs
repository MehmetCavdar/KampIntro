using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class Mylist <T>
    {
        T[] items;

        //ctor 2xtab asagidaki "Constructor" yapisini getirir. 
        public Mylist() 
        {
            items = new T[0];    
        }
        // degiskenin tipi T seklinde tanimlandi. Bu herhangi bir degisken olabilir. bu klass cagrilirken belirlenir

        public void Add (T item) 
        {
            // gecici dizinin referansini itemin referansina atadim ki kaybolmasin
            T[] tempArray = items;

            //items listesinin genisligini +1 yapiyorum
            //burada yeni bir referans numarasiyla eleman sayisi 1 fazla liste olustu        
            items = new T[items.Length +1];
            // eskiden var olan elemanlari  eleman sayisi 1 artmis olan yeni diziye aliyoruz
            for(int i = 0); i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            // simdi listenin en sonuna istenen bilgiyi ekliyoruz
            items[items.Length - 1] = item;
        }
    }
}
