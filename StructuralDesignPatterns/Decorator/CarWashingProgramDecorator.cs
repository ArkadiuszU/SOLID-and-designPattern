using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class CarWashingProgramDecorator : ICarWashingProgram
    {
        ICarWashingProgram carWashingbase;
        public static string Programs { get; set; }

        protected CarWashingProgramDecorator(ICarWashingProgram carWashingbase)
        {
            this.carWashingbase = carWashingbase;
            Programs += $" + {this.GetType().Name}";
           
        }
        public virtual double CalculatePrize()
        {
            return carWashingbase.CalculatePrize();
        }

        public virtual int GetTime()
        {
            return carWashingbase.GetTime();
        }
    }
}
