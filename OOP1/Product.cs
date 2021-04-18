using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // Bu tarz class larda sadece ürünler olur.
    class Product
    {
        // snippet : hazır kodlar demek tab tab taktiği
        
        // Ürünün ID si 
        public int Id { get; set; }

        // Ürünün Hangi kategoriye ait olduğu
        public int CategoryId { get; set; } // referans anahtarıdır.

        // Ürünün İsmi
        public string ProductName { get; set; }

        // Ürünün fiyatı
        public double UnitPrice { get; set; }
        
        // Ürünün stock adedi
        public int UnitsInStock { get; set; }

    }
}
