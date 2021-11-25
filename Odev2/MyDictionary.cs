using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2
{
    class MyDictionary<K,T>
    {
        K[] diziAnahtar;
        T[] diziDeger;
        public MyDictionary()
        {
            diziAnahtar = new K[0];
            diziDeger = new T[0];

        }

        public void Add(K anahtar, T deger)
        {
            K[] tempAnahtar = diziAnahtar;// ANAHTAR kaybı olmasın diye geçiçi anahtarları tutacak dizi
            T[] tempDeger = diziDeger;// DEGER kaybı olmasın diye geçiçi anahtarları tutacak dizi

            diziAnahtar = new K[tempAnahtar.Length + 1]; //asıl olan dizimi ve yeniden hafızaya +1 ekleyerek yer açıyoruz.
            diziDeger = new T[tempDeger.Length + 1];//asıl olan dizimi ve yeniden hafızaya +1 ekleyerek yer açıyoruz.


            for (int i = 0; i < tempAnahtar.Length; i++) //// döngü ile geçiçi devrettiğimiz değerlerimizi tekrar alıyoruz.
                {
                diziAnahtar[i] = tempAnahtar[i];
                diziDeger[i] = tempDeger[i];

            }
            diziAnahtar[diziAnahtar.Length - 1] = anahtar; // yeni anahtarları yazıyoruz.
            diziDeger[diziDeger.Length - 1] = deger; // yeni degeri yazıyoruz.

        }
       
        public int Length  // dizimizde toplam kaç boyutlu sayıyoruz.
        {
            get { return diziAnahtar.Length; }
        }

    }
}
