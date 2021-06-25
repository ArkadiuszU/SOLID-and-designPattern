using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class QuickInitialProgram : ICarWashingProgram
    {
        public double CalculatePrize()
        {
            return 2.5;
        }

        public int GetTime()
        {
            return 3;
        }
    }
}
