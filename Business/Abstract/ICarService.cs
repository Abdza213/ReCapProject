using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetById(int CarId);

        void Add(Car car);

        void Update(Car car);

        void Delete(int CarId);
    }
}
