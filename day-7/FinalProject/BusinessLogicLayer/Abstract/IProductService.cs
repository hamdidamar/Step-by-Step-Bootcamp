using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
