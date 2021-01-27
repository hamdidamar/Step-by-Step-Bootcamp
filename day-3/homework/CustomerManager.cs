using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("\n*********Add**********");
            Console.WriteLine("Customer:" + customer.Name + " has been added");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Surname);
            Console.WriteLine(customer.Phone);
            Console.WriteLine(customer.Mail);
            Console.WriteLine(customer.Address);
            Console.WriteLine("***************************");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("\n*********Delete**********");
            Console.WriteLine("Customer:" + customer.Name + " has been deleted");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("\n*********Update**********");
            Console.WriteLine("Customer:" + customer.Id + " has been updated");
        }

        public void GetCustomers(Customer[] customers)
        {
            Console.WriteLine("\n*********List**********");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Phone);
                Console.WriteLine(customer.Mail);
                Console.WriteLine(customer.Address);
                Console.WriteLine("***************************");
            }
        }
    }
}
