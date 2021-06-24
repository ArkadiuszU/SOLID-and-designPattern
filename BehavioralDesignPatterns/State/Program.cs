using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Context printContext = new Context();
            Console.WriteLine($"current context: {printContext.CurrentState.GetType()}");
            printContext.Print();
            Console.WriteLine($"current context: {printContext.CurrentState.GetType()}");
            printContext.Print();
            printContext.Clean();
            Console.WriteLine($"current context: {printContext.CurrentState.GetType()}");
            printContext.Stop();
            Console.WriteLine($"current context: {printContext.CurrentState.GetType()}");
            printContext.Clean();
            Console.WriteLine($"current context: {printContext.CurrentState.GetType()}");
            printContext.Clean();
            printContext.Stop();
            Console.WriteLine($"current context: {printContext.CurrentState.GetType()}");


        }
    }
}
