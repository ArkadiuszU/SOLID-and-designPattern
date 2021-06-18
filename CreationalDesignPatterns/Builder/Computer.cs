using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Computer
    {
        public int SerialNumber { get; set; }
        public string Brand { get; set; }
        public ComputerComponent GraphicsCard { get; set; }
        public ComputerComponent Processor { get; set; }
        public string[] Peripherals { get; set; }
    }
}
