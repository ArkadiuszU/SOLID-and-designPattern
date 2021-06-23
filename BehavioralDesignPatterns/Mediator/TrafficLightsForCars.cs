using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class TrafficLightsForCars : TrafficLights
    {
        public void CarArrived()
        {
            Console.WriteLine("Car arrived");
            mediator.ChangeLight(this);
        }
    }
}
