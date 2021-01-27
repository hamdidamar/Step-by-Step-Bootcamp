using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 1,
                ProductName = "Pencil",
                UnitPrice = 10,
                UnitsInStock = 50
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
