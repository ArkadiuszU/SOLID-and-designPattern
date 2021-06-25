using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Boss : IBossDuties
    {
        public void GiveImportantInformation()
        {
            Console.WriteLine("Please, here are important informations");
        }
    }
}
