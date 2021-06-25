using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class EvenNumber : ICheckNumber
    {
        public void Check(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
        }
    }
}
