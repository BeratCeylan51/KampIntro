using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // ProductManager classında Ürünler ile ilgili opersayonlar bulunur yani CRUD Ekle, Sil, Güncelle, Sil operasyonları
    // Bu tarz isimli class lar gördüğümüz zaman operasyonlar olduğunu bilmeliyiz.
    class ProductManager
    {

        public void Add(Product product)  
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
    }
}
// encapsulation 
/*
Kapsülleme(ya da Sarma) nesne yönelimli programlamada herhangi bir nesnenin metotlarını, verilerini ve değiskenlerini
diğer nesnelerden saklayarak ve bunlara erişimini sınırlandırarak yanlış kullanımlardan koruyan bir konsepttir.
*/
// yani Add fonksiyonuna atadığımız parametreler encapsulation içindir.