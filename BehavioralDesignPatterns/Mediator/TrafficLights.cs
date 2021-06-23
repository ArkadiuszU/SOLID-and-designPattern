using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class TrafficLights
    {
        protected IMediator mediator;

        public void SetMediator( IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void SetLight(string color)
        {
            Console.WriteLine($"I am {this.GetType()} and I am {color} now");
        }


    }
}
