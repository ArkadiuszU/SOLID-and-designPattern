using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class DrillingMachine
    {
        public void Drill()
        {
            PowerOn();
            Material();
            TurnOnRotation();
            Downward();
            Upward();
            End();
        }

        private void PowerOn()
        {
            MakeTask("Supply power on");
        }
        private void Material()
        {
            MakeTask("Get material");
        }

        protected abstract void TurnOnRotation();
        protected virtual void Downward()
        {
            MakeTask("Downward movement");
        }
        private void Upward()
        {
            MakeTask("Upward movement");
        }
        private void End()
        {
            MakeTask("Take the element with the hole");
        }
        protected void MakeTask(string task)
        {
            Console.WriteLine($"{this.GetType()}: {task}");
        }
    }
}
