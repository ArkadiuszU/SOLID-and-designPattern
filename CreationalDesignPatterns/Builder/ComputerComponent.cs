using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public enum ComputerComponentsType { GraphicsCard, Processor}
    class ComputerComponent
    {
        public ComputerComponentsType Type { get; set; }
        public int SerialNumber { get; set; }
        public string Brand { get; set; }
    }
}
