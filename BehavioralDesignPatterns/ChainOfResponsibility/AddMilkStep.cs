using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class AddMilkStep : BaseStep
    {
        public AddMilkStep(IStep nextStep) : base(nextStep) { }

        public override void ExecuteStep(OrderContext order)
        {
            if (order.Type.WithMilk)
            {
                order.Status.Message += " + milk";
            }
            order.Status.IsSuccess = true;
        }
    }
}
