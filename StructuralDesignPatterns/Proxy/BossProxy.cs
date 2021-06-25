using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class BossProxy : IBossDuties
    {
        Boss boss; 
        public void GiveImportantInformation()
        {
            if(boss is null)
            {
                this.boss = new Boss();
            }

            Console.WriteLine("This message is from boss: ");
            boss.GiveImportantInformation();
        }
    }
}
