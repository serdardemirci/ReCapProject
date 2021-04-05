using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine(carManager.GetCarById(2).Description);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Add(new Car { CarId = 6, BrandId = 3, ColorId = 7, Description = "Mercedes", DailyPrice = 169, ModelYear = 2020 });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Car carToUpdate = carManager.GetCarById(6);
            carToUpdate.Description = "Opel";
            carManager.Update(carToUpdate);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Delete(carManager.GetCarById(3));
            carManager.Delete(carManager.GetCarById(6));

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
