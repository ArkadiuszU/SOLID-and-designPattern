using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Robot : IPrototype, IHasHowToCall
    {
        public int Type { get; set; }
        public HowToCall HowToCall { get; set; }

        public IPrototype Clone()
        {
            Robot baseClone = (Robot)this.MemberwiseClone();

            
            //baseClone.HowToCall = new HowToCall { Name = this.HowToCall.Name, Nickname = this.HowToCall.Nickname };
            //or
            baseClone.HowToCall = (HowToCall)this.HowToCall.Clone();

            return baseClone;
        }

        public void SayHello()
        {
            Console.WriteLine($"Robot {HowToCall.Name} is called {HowToCall.Nickname} is {Type} type and say: bi bi!");
        }
    }
}
