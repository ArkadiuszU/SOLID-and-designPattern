using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MilitaryUnit
    {
        public IAttackStrategy AttackStrategy { get; set; }

        public MilitaryUnit( IAttackStrategy attackStrategy)
        {
            AttackStrategy = attackStrategy;
        }
        public void Attack() 
        {
            AttackStrategy.Attack();
        }
    }
}
