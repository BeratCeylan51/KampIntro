using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); // Class ı tanımlamak için bunu yapmamız gerek. buna class ın örneği denir.
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            // type safe - tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("-------------------Metotlar----------------");

            // instance - örnek
            // encapsulation  stokadedini sonradan ekledik ekle 2 kısmında parametre olarak olursa hata alırız tek tek düzeltmek lazım bu duruma

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12 , 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12 , 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12 , 6);
        }
    }
}

// Dont repeat yourself - DRY - Kendini Tekrar Etme
// Clean Code - Temiz Kod yazma 
// Best Practice - Doğru uygulama Teknikleri
