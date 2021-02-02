using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.InMemory;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }
        public List<Product> GetAll()
        {
            return _productDAL.GetAll();
        }
    }
}
