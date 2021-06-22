using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Car
    {
        public string Model { get; set; }
        public int EngineCapacity  { get; set; }
        public abstract void Summaries();
    }
}
