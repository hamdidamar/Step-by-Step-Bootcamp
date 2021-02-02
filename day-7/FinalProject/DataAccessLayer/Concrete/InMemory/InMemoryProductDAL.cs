using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete.InMemory
{
    public class InMemoryProductDAL : IProductDAL
    {
        List<Product> _products;
        public InMemoryProductDAL()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Cup",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=1,CategoryId=1,ProductName="Camera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=1,CategoryId=1,ProductName="Phone",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=1,CategoryId=1,ProductName="Keyboard",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=1,CategoryId=1,ProductName="Mouse",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            var produtToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            var produtToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            produtToUpdate.ProductName = product.ProductName;
            produtToUpdate.CategoryId = product.CategoryId;
            produtToUpdate.UnitPrice = product.UnitPrice;
            produtToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
