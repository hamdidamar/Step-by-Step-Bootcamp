using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "product1";
            product1.Price = 25.90;
            product1.Explanation = "Product 1 Explantation";


            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "product2";
            product2.Price = 29.90;
            product2.Explanation = "Product 2 Explantation";


            Product[] products = new Product[]
            {
                product1,
                product2
            };

            Console.WriteLine("\n**********Products**********");
            foreach (var product in products)
            {
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("***************************");
            }

            Console.WriteLine("\n**********Methods**********");
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);
        }
    }
}
