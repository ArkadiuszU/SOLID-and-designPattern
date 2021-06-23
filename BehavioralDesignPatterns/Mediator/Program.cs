using System;
using System.Collections.Generic;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<TrafficLights> trafficLights = new List<TrafficLights>();

            TrafficLightsForCars trafficLightsForCars = new TrafficLightsForCars();
            TrafficLightsForPedestrians trafficLightsForPedestrians = new TrafficLightsForPedestrians();

            trafficLights.Add(trafficLightsForPedestrians);
            trafficLights.Add(trafficLightsForCars);

            TrafficMediator trafficMediator = new TrafficMediator(trafficLights);

            trafficLightsForCars.CarArrived();
            trafficLightsForPedestrians.PedestriansArrived();
        }
    }
}
