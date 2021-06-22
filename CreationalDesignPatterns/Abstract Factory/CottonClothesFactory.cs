using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class CottonClothesFactory : IClothesFactory
    {
        public Pants CreatePants()
        {
            return new CottonPants();
        }

        public Tshirt CreateTshirt()
        {
            return new CottonTshirt();
        }
    }
}
