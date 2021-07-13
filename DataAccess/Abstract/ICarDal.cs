using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{    //  GetById, GetAll, Add, Update, Delete
    public interface ICarDal
    {
        List<Car> GetAll();

        List<Car> GetById(int CarId);

        void Add(Car car);

        void Update(Car car);

        void Delete(int CarId);
        

    }
}
