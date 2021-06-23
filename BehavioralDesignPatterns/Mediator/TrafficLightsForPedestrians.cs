using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class TrafficLightsForPedestrians : TrafficLights
    { 
        public void PedestriansArrived()
        {
            Console.WriteLine("Pedestrians Arrived");
            mediator.ChangeLight(this);
        }
    }
}
