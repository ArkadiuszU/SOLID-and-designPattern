using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class LessToTen : ICheckNumber
    {
        public void Check(int number)
        {
            if (number < 10)
            {
                Console.WriteLine("Is less to ten");
            }
        }
    }
}
