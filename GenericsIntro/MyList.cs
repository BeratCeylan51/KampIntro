using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // type ın t sinden geliyor böyle kullanmanın avantajı istediğimiz değeri alabilir olmasıdır.
    {
        T[] items;

        // constructor - Bir class new lendiğinde çalışan bloğa denir
        public MyList() // biz class ı bir yerde new lersek burası otamatik çalışır.
        {
            items = new T[0];
        }
        public void Add(T item) // item eleman demek 
        {
            T[] tempArray = items; // geçici dizi ile elemanları bir değere eşitledik her newlemede elemanları kaybetmemek için
            items = new T[items.Length + 1]; // items dizisinin eleman sayısını bir artırdık

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // tempArray in tuttuğu bir önceki referance numarasında bulunan değerleri tekrar alıyorum
            }

            items[items.Length - 1] = item;
        }
    }
}
