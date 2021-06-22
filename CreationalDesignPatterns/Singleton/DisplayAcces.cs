using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class DisplayAcces
    {
        private static DisplayAcces display;
        public int  DisplayId { get; set; }

        private  DisplayAcces()
        {
            //no possibility to create instance outside
        }
        public void Display(string msg)
        {
            Console.WriteLine($"Display will print: {msg}");
        }
        public static  DisplayAcces GetInstance()
        {
            if(display is null)
            {
                display = new DisplayAcces();
            }

            return display;
        }


    }
}
