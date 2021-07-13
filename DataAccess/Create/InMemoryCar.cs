using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Create
{
    public class InMemoryCar : ICarDal
    {
        List<Car> _cars;

        public InMemoryCar()
        {
        _cars = new List<Car>
        {
             new Car { CarId = 1, BrandName = "BMW", BrandId = 1, ColorId  = "#FF0000", DailyPrice = 200, ModelYear = "2015", Description = "Şehrin içinde" },
             new Car { CarId = 2, BrandName = "Tesla", BrandId = 2, ColorId  = "#C0C0C0", DailyPrice = 500, ModelYear = "2020", Description = "Şehrin dışında" },
             new Car { CarId = 3, BrandName = "Honda Civciv", BrandId = 1, ColorId  = "#F0F8FF", DailyPrice = 350, ModelYear = "2018", Description = "Şehrin içinde" },
             new Car { CarId = 4, BrandName = "Mercedes", BrandId = 3, ColorId  = "#FF0000", DailyPrice = 400, ModelYear = "2019", Description = "Şehrin dışında" }
        };
        }

        public List<Car> GetAll()
        {
            return _cars; //forloop حيث يتم وضعها داخل  
                         // يتم الطباعة حسب المطلوب 
        }

        public void Add(Car car)
        {
            
            _cars.Add(car);

        }

        public void Delete(int CarId)
        {
            Car CarToDelete = null;

            CarToDelete = _cars.SingleOrDefault(P=> P.CarId == CarId );

            _cars.Remove(CarToDelete);
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(P => P.CarId == CarId).ToList();
        }

        public void Update(Car car)
        {
            

            Car CarToUpdate = _cars.SingleOrDefault(P => P.CarId == car.CarId);

            _cars.Remove(CarToUpdate);
            
            _cars.Add(car);

           
        }
    }
}
