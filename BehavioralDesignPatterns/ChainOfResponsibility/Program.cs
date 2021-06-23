using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddMilkStep milkStep = new AddMilkStep(null);
            AddSugarStep sugarStep = new AddSugarStep(milkStep);
            CupSelectStep cupStep = new CupSelectStep(sugarStep);


            Console.WriteLine("-----*-----");
            OrderContext order = new OrderContext { Type = new OrderType { SelectedCubSize = CupSize.medium, WithMilk = true, WithSugar = true } };
            cupStep.ExecuteStep(order);
            Console.WriteLine($"Success: {order.Status.IsSuccess}, message: {order.Status.Message}");

            Console.WriteLine("-----*-----");
            order = new OrderContext { Type = new OrderType { SelectedCubSize = CupSize.small, WithMilk = true, WithSugar = true } };
            cupStep.ExecuteStep(order);
            Console.WriteLine($"Success: {order.Status.IsSuccess}, message: {order.Status.Message}");

            Console.WriteLine("-----*-----");
            order = new OrderContext { Type = new OrderType { SelectedCubSize = CupSize.large, WithMilk = false, WithSugar = true } };
            cupStep.ExecuteStep(order);
            Console.WriteLine($"Success: {order.Status.IsSuccess}, message: {order.Status.Message}");

            Console.WriteLine("-----*-----");
            order = new OrderContext { Type = new OrderType { SelectedCubSize = CupSize.large, WithMilk = true, WithSugar = false } };
            cupStep.ExecuteStep(order);
            Console.WriteLine($"Success: {order.Status.IsSuccess}, message: {order.Status.Message}");

        }
    }
}
