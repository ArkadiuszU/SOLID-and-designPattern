using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method");
            Console.WriteLine("------*-------");

            CarFactory carFactory = new CarFactory();

            List<Car> cars = new List<Car>();

            cars.Add(carFactory.CreateCar(CarType.Electric));
            cars.Add(carFactory.CreateCar(CarType.Petrol));
            cars.Add(carFactory.CreateCar(CarType.Diesel));

            foreach (Car item in cars)
            {
                item.Summaries();
            }
        }
    }
}
