using BusinessLogicService.Concrete;
using DataAccessLayer.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDAL());
            BrandManager brandManager = new BrandManager(new InMemoryBrandDAL());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}
