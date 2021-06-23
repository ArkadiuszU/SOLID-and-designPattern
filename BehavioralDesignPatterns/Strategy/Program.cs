using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MilitaryUnit unit1 = new MilitaryUnit(new DistanceAttackStrategy());

            unit1.Attack();

            unit1.AttackStrategy = new MeleeAttackStrategy();

            unit1.Attack();
        }
    }
}
