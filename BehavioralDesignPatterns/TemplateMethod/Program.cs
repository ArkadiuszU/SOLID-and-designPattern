using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SteelDrillingMachine steelMachine = new SteelDrillingMachine();

            WoodDrillingMachine woodMachine = new WoodDrillingMachine();


            Console.WriteLine("");
            Console.WriteLine("Steel drilling:");
            steelMachine.Drill();
            Console.WriteLine("");
            Console.WriteLine("Wood drilling:");
            woodMachine.Drill();
        }
    }
}
