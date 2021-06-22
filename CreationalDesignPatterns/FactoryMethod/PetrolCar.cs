using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class PetrolCar : Car
    {
        public bool GasInstallation { get; set; }
        public override void Summaries()
        {
            Console.WriteLine($"Car type: {this.GetType()}, model: {Model}, engine: {EngineCapacity} cm3, gasInstalation: {GasInstallation}" );
        }
    }
}
