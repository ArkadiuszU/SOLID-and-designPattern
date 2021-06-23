using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class SteelDrillingMachine : DrillingMachine
    {
        protected override void TurnOnRotation()
        {
            MakeTask("Turn 300 rmp rotation");
        }

        protected override void Downward()
        {
            base.Downward();
            Console.WriteLine(" __ with coolant fluid");
        }
    }
}
