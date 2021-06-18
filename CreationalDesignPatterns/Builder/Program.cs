using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder");

            ComputerBuilder builder = new ComputerBuilder();

            builder.SetBrand("DELL");
            builder.SetSerialNumber(1234);
            builder.SetPeripherals(new string[] { "keyboard", "mouse", "screen" } );
            builder.SetProcessor(new ComputerComponent
            {
                Type = ComputerComponentsType.Processor,
                Brand = "Intel",
                SerialNumber = 1234
            });
            builder.SetGraphicsCard(new ComputerComponent
            {
                Type = ComputerComponentsType.GraphicsCard,
                Brand = "Nvidia",
                SerialNumber = 1234
            });

            Computer myComputer = builder.Build();
            Console.WriteLine("-------*-------");
            Console.WriteLine($"Computer: {myComputer.Brand}");
            Console.WriteLine($"{myComputer.Processor.Type}: {myComputer.Processor.Brand}");
            Console.WriteLine($"{myComputer.Processor.Type}: {myComputer.GraphicsCard.Brand}");
            Console.WriteLine("Peripherals:");
            foreach (var item in myComputer.Peripherals)
            {
                Console.WriteLine($"    {item}");
            }
            


        }
    }
}
