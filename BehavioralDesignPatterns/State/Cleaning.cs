using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Cleaning : State
    {

        public Cleaning(Context context) : base(context) { }

        public override void Clean()
        {
            Console.WriteLine("I cleaning now, this command will be rejected");
        }

        public override void Print()
        {
            Console.WriteLine("This command is not available in Cleaning state");
        }

        public override void Stop()
        {
            Console.WriteLine("Ok, I stop cleaning");
            context.ChangeState(new Idle(context));
        }
    }
}
