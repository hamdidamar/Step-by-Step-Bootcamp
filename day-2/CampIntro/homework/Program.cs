using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.Name = "Pencil";
            product1.Price = 15;
            product1.Stock = 20;
            product1.IsActive = true;

            Product product2 = new Product();
            product2.ID = 1;
            product2.Name = "Notebook";
            product2.Price = 20;
            product2.Stock = 50;
            product2.IsActive = true;

            Product product3 = new Product();
            product3.ID = 1;
            product3.Name = "Notebook";
            product3.Price = 20;
            product3.Stock = 50;
            product3.IsActive = true;

            Product[] products = new Product[]
            {
                product1,product2,product3
            };

            Console.WriteLine("******For Loop*********\n");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name);
            }
            Console.WriteLine("-----------------------\n");

            Console.WriteLine("******Foreach Loop*********\n");
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine("-----------------------\n");

            Console.WriteLine("******While Loop*********\n");
            int count = 0;
            while (count<products.Length)
            {
                Console.WriteLine(products[count].Name);
                count++;
            }
            Console.WriteLine("-----------------------\n");


        }
    }

    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Stock { get; set; }
        public bool IsActive { get; set; }

    }
}
