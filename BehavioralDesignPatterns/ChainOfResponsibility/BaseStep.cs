using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
     abstract class BaseStep : IStep
    {
        public IStep nextStep;

        public BaseStep(IStep nextStep)
        {
            this.nextStep = nextStep;
        }
        public abstract void ExecuteStep(OrderContext order);

    }
}
