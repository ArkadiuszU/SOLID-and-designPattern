using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class HowToCall : IPrototype
    {
        public string Name { get; set; }
        public string Nickname { get; set; }

        public IPrototype Clone()
        {
            return (HowToCall)this.MemberwiseClone();
        }
    }
}
