using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Context
    {
        private State currentState;

        internal State CurrentState { get => currentState; }

        public Context()
        {
            this.currentState = new Idle(this);
        }

        public void ChangeState(State newState)
        {
            this.currentState = newState;
        }
        public  void Print()
        {
            this.currentState.Print();
        }

        public  void Clean()
        {
            this.currentState.Clean();
        }

        public  void Stop()
        {
            this.currentState.Stop();
        }
    }
}
