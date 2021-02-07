using BusinessLogicService.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicService.Concrete
{
    public class CarManager:ICarService
    {
        ICarDAL _carDAL;
        public CarManager(ICarDAL carDAL)
        {
            _carDAL = carDAL;
        }

        public void Add(Car car)
        {
            _carDAL.Add(car);
        }

        public void Delete(Car car)
        {
            _carDAL.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDAL.GetAll();
        }

        public List<Car> GetAllById(int carId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByUnitPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Car product)
        {
            throw new NotImplementedException();
        }
    }
}
