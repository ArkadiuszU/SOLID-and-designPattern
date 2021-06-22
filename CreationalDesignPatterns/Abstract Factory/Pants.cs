using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public abstract class Pants
    {
        public string Material { get; set; }

        public void Summary()
        {
            Console.WriteLine($"I am {Material} Pants");
        }
    }
}
