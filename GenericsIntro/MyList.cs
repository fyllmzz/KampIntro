using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;// clası new lediğimde oluşturmam gerekiyor.

        //clası biryerde newlersen bu MyList() otomatik çalışır.
        public MyList() //ctor tab tab =constructor
        {
            items = new T[0];//newledin 0 elemanlı olarak verdim.
        }
        public void Add(T item)//item=eleman
        {
            T[] tempArray = items; //geçici diziye attık, bilgilar uçmasın diye// referans num. tutar

            items = new T[items.Length + 1]; //dizinin eleman sayısını bir artırır.  
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;//aslında eklenmek istenen elemanı şuan ekledim.
        }

        public int Length
        {
            get { return items.Length; }
        }
    }
}
