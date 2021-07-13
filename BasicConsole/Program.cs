using Business.Create;
using DataAccess.Create;
using Entities.Abstract;
using System;

namespace BasicConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManeger carManeger = new CarManeger(new InMemoryCar());

            //
            //...
            foreach (var P in carManeger.GetAll())
            {
                Console.WriteLine(P.CarId + " || " + P.BrandName);
            }

            //
            //
            Console.WriteLine("---------------");

            carManeger.Add(new Car { CarId = 6, BrandName = "Tesla" });


            foreach (var P in carManeger.GetAll())
            {
                Console.WriteLine(P.CarId + " || " + P.BrandName);
            }
            //
            //
            Console.WriteLine("---------------");

            carManeger.Delete(1); // 

            foreach (var P in carManeger.GetAll())
            {
                Console.WriteLine(P.CarId + " || " + P.BrandName);
            }
            //
            //

            Console.WriteLine("---------------");

            carManeger.Update(new Car { CarId = 1, BrandName = "Scoda" });
            
            foreach (var P in carManeger.GetAll())
            {
                Console.WriteLine(P.CarId + " || " + P.BrandName);
            }
            //
            //

            Console.WriteLine("---------------");

            carManeger.Add(new Car { CarId = 7, BrandName = "oudi" });

            foreach (var P in carManeger.GetAll())
            {
                Console.WriteLine(P.CarId + " || " + P.BrandName);
            }
            //
            //
            Console.WriteLine("---------------");

            foreach (var P in carManeger.GetById(7))
            {
                Console.WriteLine(P.CarId + " || " + P.BrandName);
            }

            Console.ReadKey();
        }
    }
}
