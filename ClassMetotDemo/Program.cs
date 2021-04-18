using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = "1";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.CityOfResidence = "İstanbul";
            customer1.age = 35;

            Customer customer2 = new Customer();
            customer2.Id = "2";
            customer2.Name = "Berat";
            customer2.Surname = "Ceylan";
            customer2.CityOfResidence = "Niğde";
            customer2.age = 19;

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

            customerManager.Lists(customers);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

            customerManager.Delete(customer2);
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
        }
    }
}
