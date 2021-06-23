using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MeleeAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Go closer and hit !");
        }
    }
}
