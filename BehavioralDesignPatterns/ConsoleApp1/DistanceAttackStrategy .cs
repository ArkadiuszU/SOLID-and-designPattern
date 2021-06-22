using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DistanceAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Stay behind and fire !");
        }
    }
}
