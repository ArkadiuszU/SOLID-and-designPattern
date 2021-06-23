using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class CupSelectStep : BaseStep
    {
        private int[] cupCounters = new int[] { 0, 3, 1 }; 
        public CupSelectStep(IStep nextStep) : base(nextStep) { }
        public override void ExecuteStep(OrderContext order)
        {
            if(cupCounters[ (int) order.Type.SelectedCubSize] > 0)
            {
                order.Status.Message = $"{order.Type.SelectedCubSize} cup";
                nextStep.ExecuteStep(order);
            }
            else
            {
                order.Status.IsSuccess = false;
                order.Status.Message = "cup container is empty";
            }
        }
    }
}
