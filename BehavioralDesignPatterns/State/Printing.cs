using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Printing : State
    {
        public Printing(Context context) : base(context) { }

        public override void Print()
        {
            Console.WriteLine("I printing now, this command will be rejected");
        }

        public override void Clean()
        {
            Console.WriteLine("This command is not available in Printing state");
        }

        public override void Stop()
        {
            Console.WriteLine("Ok, I stop printing");
            context.ChangeState(new Idle(context));
        }
    }
}
