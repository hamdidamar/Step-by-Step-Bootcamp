using BusinessLogicService.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicService.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDAL _brandDAL;
        public BrandManager(IBrandDAL brandDAL)
        {
            _brandDAL = brandDAL;
        }
        public void Add(Brand brand)
        {
            _brandDAL.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDAL.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDAL.GetAll();
        }

        public List<Brand> GetAllById(int brandId)
        {
            return _brandDAL.GetAllById(brandId);
        }

        public Brand GetBrandById(int id)
        {
            return _brandDAL.GetBrandById(id);
        }

        public void Update(int id, Brand brand)
        {
            _brandDAL.Update(id, brand);
        }
    }
}
