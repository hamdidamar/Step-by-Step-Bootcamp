using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICarDAL
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(int id,Car car);
        void Delete(Car car);
        List<Car> GetAllById(int carId);

        Car GetCarById(int id);
    }
}
