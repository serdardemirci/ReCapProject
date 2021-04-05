using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car {CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 89, Description = "Seat", ModelYear = 2019},
                new Car {CarId = 2, BrandId = 1, ColorId = 1, DailyPrice = 119, Description = "VW", ModelYear = 2019},
                new Car {CarId = 3, BrandId = 3, ColorId = 2, DailyPrice = 189, Description = "Audi", ModelYear = 2021},
                new Car {CarId = 4, BrandId = 2, ColorId = 3, DailyPrice = 129, Description = "BMW", ModelYear = 2020},
                new Car {CarId = 5, BrandId = 2, ColorId = 3, DailyPrice = 59, Description = "Fiat", ModelYear = 2020},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            _cars.Remove(_cars.SingleOrDefault(c => c.CarId == car.CarId));
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetCarById(int carId)
        {
            return _cars.SingleOrDefault(c => c.CarId == carId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
