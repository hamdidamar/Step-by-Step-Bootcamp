using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class InMemoryBrandDAL : IBrandDAL
    {
        List<Brand> _brands;
        public InMemoryBrandDAL()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="TOGG"},
                new Brand{BrandId=2,BrandName="Ford"},
                new Brand{BrandId=3,BrandName="BMW"}
            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            var brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetAllById(int brandId)
        {
            return _brands.Where(b => b.BrandId == brandId).ToList();
        }

        public Brand GetBrandById(int id)
        {
            return _brands.SingleOrDefault(b => b.BrandId == id);
        }

        public void Update(int id, Brand brand)
        {
            var brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == id);
            brandToUpdate.BrandId = brand.BrandId;
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}
