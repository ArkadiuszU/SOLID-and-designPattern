using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class AddSugarStep : BaseStep
    {
        public AddSugarStep(IStep nextStep) : base(nextStep) { }

        public override void ExecuteStep(OrderContext order)
        {
            if(order.Type.WithSugar)
            {
                order.Status.Message += " + sugar";
            }

            nextStep.ExecuteStep(order);
        }
    }
}
