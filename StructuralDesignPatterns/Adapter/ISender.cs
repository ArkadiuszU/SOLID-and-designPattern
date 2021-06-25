using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface ISender
    {
        public void SendMessage(int userId, string message);
    }
}
