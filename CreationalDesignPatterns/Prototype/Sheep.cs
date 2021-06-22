using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Sheep : IPrototype, IHasHowToCall
    {
        public string Breed { get; set; }
        public HowToCall HowToCall { get; set; }

        public IPrototype Clone()
        {
            return  (Sheep)this.MemberwiseClone();
        }

        public void SayHello()
        {
            Console.WriteLine($"Sheep {HowToCall.Name} is called {HowToCall.Nickname} is {Breed} breed and say: beeee!");
        }
    }
}
