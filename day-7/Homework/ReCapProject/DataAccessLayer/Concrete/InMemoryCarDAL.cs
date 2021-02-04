using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class InMemoryCarDAL:ICarDAL
    {
        List<Car> _cars;
        public InMemoryCarDAL()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,ModelYear="2005",DailyPrice=150,Description="description"},
                new Car{CarId=2,BrandId=2,ColorId=1,ModelYear="2007",DailyPrice=130,Description="description"},
                new Car{CarId=3,BrandId=1,ColorId=2,ModelYear="2020",DailyPrice=300,Description="description"},
                new Car{CarId=4,BrandId=3,ColorId=1,ModelYear="2015",DailyPrice=250,Description="description"},
                new Car{CarId=5,BrandId=2,ColorId=2,ModelYear="2009",DailyPrice=200,Description="description"}
            };
        }
        
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }


        public Car GetCarById(int id)
        {
            return _cars.SingleOrDefault(c => c.CarId == id);
        }

        public void Update(int id, Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.CarId == id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
