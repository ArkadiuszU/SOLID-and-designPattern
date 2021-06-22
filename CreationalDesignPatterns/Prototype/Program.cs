using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Sheep sheep1 = new Sheep { Breed = "Dorper", HowToCall = new HowToCall { Name = "Shaun", Nickname = "Shaun the sheep"}};
            Robot robot1 = new Robot { Type = 12321, HowToCall = new HowToCall { Name = "R2-D2", Nickname = "Artuditu" } };

            Sheep sheep2 = (Sheep)sheep1.Clone();
            Robot robot2 = (Robot)robot1.Clone();

            Check(sheep1, sheep2);
            Check(robot1, robot2);
        }

        private static void Check(IHasHowToCall ob1, IHasHowToCall ob2)
        {
            ob1.SayHello();
            ob2.SayHello();
            Console.WriteLine($"Shallow clone: {!ReferenceEquals(ob1, ob2)}, deep clone {!ReferenceEquals(ob1.HowToCall, ob2.HowToCall)} ");
        }
    }
}
