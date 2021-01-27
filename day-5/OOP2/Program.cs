using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.Id = 1;
            individualCustomer1.CustomerNumber = "c1";
            individualCustomer1.TaxNumber = "t1";
            individualCustomer1.TurkishIdentityNumber = "11111111111";
            individualCustomer1.Name = "individual name 1";
            individualCustomer1.Surname = "individual surname 1";

            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.Id = 1;
            corporateCustomer1.CustomerNumber = "c2";
            corporateCustomer1.TaxNumber = "t2";
            corporateCustomer1.CompanyName = "company name 1";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer1);
            customerManager.Add(corporateCustomer1);
        }
    }
}
