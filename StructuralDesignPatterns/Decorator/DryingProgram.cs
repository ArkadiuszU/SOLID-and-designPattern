using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DryingProgram : CarWashingProgramDecorator
    {
        public DryingProgram(ICarWashingProgram carWashingProgram) : base(carWashingProgram) { }

        public override double CalculatePrize()
        {
            return base.CalculatePrize() + 3.4;
        }

        public override int GetTime()
        {
            return base.GetTime() + 5;
        }
    }
}
