using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "customer1";
            customer1.Surname = "surname1";
            customer1.Phone = "11111111111";
            customer1.Mail = "mail1@mail.com";
            customer1.Address = "address 1";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "customer2";
            customer2.Surname = "surname2";
            customer2.Phone = "22222222222";
            customer2.Mail = "mail2@mail.com";
            customer2.Address = "address 2";

            Customer[] customers = new Customer[]
            {
                customer1,
                customer2
            };

            CustomerManager customerManager = new CustomerManager();
            
            //Add
            customerManager.Add(customer1);

            //Delete
            customerManager.Delete(customer2);

            //Update
            customerManager.Update(customer1);

            //List
            customerManager.GetCustomers(customers);

        }
    }
}
