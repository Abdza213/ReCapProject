using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Create
{
    public class CarManeger : ICarService
    {
        ICarDal _icarDal;

        public CarManeger(ICarDal icarDal)
        {
            _icarDal = icarDal;
        }

        public void Add(Car car)
        {
            foreach (var P in _icarDal.GetAll())
            {
                if(P.CarId == car.CarId)
                {
                    throw new Exception("There is an error in ID, Please ty again"); 
                } 
            }
            _icarDal.Add(car);
        }

        public void Delete(int CarId)
        {
            _icarDal.Delete(CarId);
        }

        public List<Car> GetAll()
        {
            return _icarDal.GetAll();
        }

        public List<Car> GetById(int CarId)
        {
            foreach (var P in _icarDal.GetAll())
            {
                if (P.CarId == CarId)
                {
                    return _icarDal.GetById(CarId); 
                }
            }
            throw new Exception("There is an error in ID, Please ty again");
        }

        public void Update(Car car)
        {
            _icarDal.Update(car);
        }
    }
}
