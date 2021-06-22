using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    interface IPrototype
    {
        public IPrototype Clone();
    }

    interface IHasHowToCall
    {
        public HowToCall HowToCall { get; set; }
        public void SayHello();
    }
}
