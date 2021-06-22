using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public enum CarType { Electric, Diesel, Petrol} 
    class CarFactory
    {
        public Car CreateCar(CarType carType)
        {
            switch (carType)
            {
                case CarType.Diesel:
                    return new DieselCar();
                case CarType.Petrol:
                    return new PetrolCar();
                case CarType.Electric:
                    return new ElectricCar();
                default:
                    throw new Exception($"{carType} is not know");
            }
        }
    }
}
