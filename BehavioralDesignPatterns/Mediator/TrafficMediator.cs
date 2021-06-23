using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class TrafficMediator : IMediator
    {

        private List<TrafficLights> trafficLights = new List<TrafficLights>();
        public TrafficMediator(List<TrafficLights> trafficLights)
        {
            this.trafficLights = trafficLights;

            foreach (var item in this.trafficLights)
            {
                item.SetMediator(this);
            }

        }
        public void ChangeLight(TrafficLights trafficLights)
        {
            foreach (TrafficLights item in this.trafficLights)
            {
                if(item.GetType() == trafficLights.GetType())
                {
                    item.SetLight("green");
                }
                else
                {
                    item.SetLight("red");
                }
            }                  
        }
    }
}
