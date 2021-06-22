using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface ISubscriber
    {
        public string Name { get; set; }
        public void Update(string msg);
    }
}
