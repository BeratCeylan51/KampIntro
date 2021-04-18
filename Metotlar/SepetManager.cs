using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager // Manager DAL vs kullanımlar operasyon olarak kullanılır
    {
        // naming convention - isimlendirme kuralı
        // syntax - söz dizimi
        public void Ekle(Product product) // bir yerde parantez görüyorsak java ve C# da büyük ihtimalle metot vardır.
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Adi);
        }

        public void Ekle2(string productAdi , string aciklama , double fiyat , int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + productAdi);
        }
    }
}
