using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class ComputerBuilder
    {
        private Computer computer = new Computer();

        public Computer Build() { return this.computer; }

        public void SetSerialNumber(int serial)
        {
            computer.SerialNumber = serial;
        }
        public void SetBrand(string brand)
        {
            computer.Brand = brand;
        }
        public void SetPeripherals( string[] peripherals)
        {
            computer.Peripherals = peripherals;
        }
        public void SetGraphicsCard(ComputerComponent graphicsCard)
        {
            computer.GraphicsCard = graphicsCard;
        }
        public void SetProcessor(ComputerComponent processor)
        {
            computer.Processor = processor;
        }

    }
}
