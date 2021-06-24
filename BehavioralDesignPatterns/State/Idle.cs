using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Idle : State
    {
        public Idle(Context context) : base(context) { }

        public override void Print()
        {
            Console.WriteLine("Ok, I start printing");
            context.ChangeState(new Printing(context));
        }

        public override void Clean()
        {
            Console.WriteLine("Ok, I start cleaning");
            context.ChangeState(new Cleaning(context));
        }

        public override void Stop()
        {
            Console.WriteLine("I am Idle now, this command will be rejected");
        }
    }
}
