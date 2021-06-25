using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ICarWashingProgram carWashingProgram = new QuickInitialProgram();

            Type baseType = carWashingProgram.GetType();

            Console.WriteLine($"Prize: {carWashingProgram.CalculatePrize()} Time: {carWashingProgram.GetTime()} Type: {baseType} {CarWashingProgramDecorator.Programs}");

            carWashingProgram = new WaxingProgram(carWashingProgram);

            Console.WriteLine($"Prize: {carWashingProgram.CalculatePrize()} Time: {carWashingProgram.GetTime()} Type: {baseType} {CarWashingProgramDecorator.Programs}");

            carWashingProgram = new DryingProgram(carWashingProgram);

            Console.WriteLine($"Prize: {carWashingProgram.CalculatePrize()} Time: {carWashingProgram.GetTime()} Type: {baseType} {CarWashingProgramDecorator.Programs}");

            carWashingProgram = new DryingProgram(carWashingProgram);

            Console.WriteLine($"Prize: {carWashingProgram.CalculatePrize()} Time: {carWashingProgram.GetTime()} Type: {baseType} {CarWashingProgramDecorator.Programs}");

        }
    }
}
