using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IClothesFactory cottonClothesFactory = new CottonClothesFactory();
            IClothesFactory polyesterClothesFactory = new PolyesterClothesFactory();


            Pants firstClothes = cottonClothesFactory.CreatePants();
            Pants secoundClothes = polyesterClothesFactory.CreatePants();

            Tshirt anotherClothes = polyesterClothesFactory.CreateTshirt();
            Tshirt lastClothes = cottonClothesFactory.CreateTshirt();

            firstClothes.Summary();
            secoundClothes.Summary();
            anotherClothes.Summary();
            lastClothes.Summary();

        }
    }
}
