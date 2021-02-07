using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicService.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car product);
        void Update(int id,Car product);
        void Delete(Car product);
        List<Car> GetAllById(int carId);
        List<Car> GetByUnitPrice(decimal min, decimal max);
    }
}
