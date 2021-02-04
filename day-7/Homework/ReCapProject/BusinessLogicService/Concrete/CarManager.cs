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
            return _carDAL.GetAllById(carId);
        }

        public void Update(int id,Car car)
        {
            _carDAL.Update(id,car);
        }

    }
}
