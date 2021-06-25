using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class GreaterThanFive : ICheckNumber
    {
        public void Check(int number)
        {
           if(number > 5)
            {
                Console.WriteLine("Is Greater Than Five");
            }
        }
    }
}
