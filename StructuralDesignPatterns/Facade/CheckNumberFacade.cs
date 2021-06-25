using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class CheckNumberFacade : ICheckNumber
    {
        List<ICheckNumber> checkNumbers = new List<ICheckNumber>();

        public CheckNumberFacade()
        {
            checkNumbers.AddRange(new List<ICheckNumber>{ new EvenNumber(), new GreaterThanFive(), new LessToTen()});
        }
       
        public void Check(int number)
        {
            Console.WriteLine($"I will check {number}");
            foreach (ICheckNumber item in checkNumbers)
            {
                item.Check(number);
            }
        }
    }
}
