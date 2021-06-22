using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ElectricCar : Car
    {
        public override void Summaries()
        {
            Console.WriteLine($"Car type: {this.GetType()}, model: {Model}, engine: {EngineCapacity} kW");
        }
    }
}
