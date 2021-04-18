using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi." + customer.Name + " " + customer.Surname);
        }

        public void Lists(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.CityOfResidence);
                Console.WriteLine(customer.age);
                Console.WriteLine("-----------------------");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi." + customer.Name + " " + customer.Surname);
        }
    }
}
