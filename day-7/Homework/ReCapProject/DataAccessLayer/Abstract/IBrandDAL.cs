using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IBrandDAL
    {
        List<Brand> GetAll();
        void Add(Brand brand);
        void Update(int id, Brand brand);
        void Delete(Brand brand);

        List<Brand> GetAllById(int brandId);

        Brand GetBrandById(int id);
    }
}
