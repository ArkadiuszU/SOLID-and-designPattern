using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            DisplayAcces displayForUser1 = DisplayAcces.GetInstance();
            DisplayAcces displayForUser2 = DisplayAcces.GetInstance();

            displayForUser1.DisplayId = 12;
            displayForUser2.Display(Convert.ToString(displayForUser2.DisplayId));

            if(ReferenceEquals(displayForUser1, displayForUser2))
            {
                Console.WriteLine("Yes! Singleton");
            }
            else
            {
                Console.WriteLine("no this obj are different");
            }
        }
    }
}
