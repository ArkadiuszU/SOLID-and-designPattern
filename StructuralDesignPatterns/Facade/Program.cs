using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CheckNumberFacade facade = new CheckNumberFacade();

            facade.Check(12);
            facade.Check(3);
            facade.Check(6);
        }
    }
}
