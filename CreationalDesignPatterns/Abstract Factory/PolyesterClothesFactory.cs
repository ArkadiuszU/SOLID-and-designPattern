using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class PolyesterClothesFactory : IClothesFactory
    {
        public Pants CreatePants()
        {
            return new PolyesterPants();
        }

        public Tshirt CreateTshirt()
        {
            return new PolyesterTshirt();
        }
    }
}
