using System;

namespace Gun2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Kitap = "TYT Konu Anlatımı";
            product1.Kirtasiye = "Boyalar ve Boya Kalemleri";

            Product product2 = new Product();
            product2.Kitap = "Kpss Soru Bankası";
            product2.Kirtasiye = "Cetveller";

            Product product3 = new Product();
            product3.Kitap = "Dgs Kitapları";
            product3.Kirtasiye = "Fiber Uçlu Kalemler";

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Kitap + "\n" + product.Kirtasiye);
            }
            Console.WriteLine("******************Foreach Bitti********************");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Kitap + "\n" + products[i].Kirtasiye);
            }
            Console.WriteLine("*************For Bitti******************************");

            int a = 0;

            while (a < products.Length)
            {
                Console.WriteLine(products[a].Kitap + "\n" + products[a].Kirtasiye);
                a++;
            }
            Console.WriteLine("*************While Bitti****************************");
        }
    }

    class Product
    {
        public string Kitap { get; set; }
        public string Kirtasiye { get; set; }
    }
}
