using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class LongerInitialProgram : ICarWashingProgram
    {
        public double CalculatePrize()
        {
            return 3.2;
        }

        public int GetTime()
        {
            return 5;
        }
    }
}
