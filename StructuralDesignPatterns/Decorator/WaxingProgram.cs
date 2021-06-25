using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class WaxingProgram : CarWashingProgramDecorator
    {
        public WaxingProgram(ICarWashingProgram carWashingProgram) : base(carWashingProgram) { }

        public override double CalculatePrize()
        {
            return base.CalculatePrize() + 2.6;
        }

        public override int GetTime() 
        {
            return base.GetTime() + 3;
        }


    }
}
