using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            Console.WriteLine("\nNewlendikten sonra isimler dizisi");
            // 18.satırdaki gibi new leme yapmadan yeni bir değer ekleyemiyoruz.
            // 18. satırdaki gibi diziyi new lersek bu sefer 9. satırdaki yazdığımız değerleri kaybediyoruz.
            // new demek yeni raferance adresi demek
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);


            Console.WriteLine("\nKoleksiyonlar");
            // koleksiyonlar
            // kullanmak için 2. satırda bulunan kütüphane eklenmelidir.
            // Dizilerden daha kullanışlıdır
            // List of string diye okunur
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            // Koleksiyonlara yeni değer ekleme 
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
// ctrl + K cctrl + C tuşları seçili alanı açıklama satırı yapar.ll
// geri almak için ctrl + K ctrl + U yapılır.