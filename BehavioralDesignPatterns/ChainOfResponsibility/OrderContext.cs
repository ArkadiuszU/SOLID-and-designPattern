using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    enum CupSize { small, medium, large}
    class OrderType
    {
        public CupSize SelectedCubSize { get; set; }
        public bool WithMilk { get; set; }
        public bool WithSugar { get; set; }
    }

    class OrderStatus
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    class OrderContext
    {
        public OrderStatus Status { get; set; }
        public OrderType Type { get; set; }

        public OrderContext()
        {
            Status = new OrderStatus();
        }
    }
}
