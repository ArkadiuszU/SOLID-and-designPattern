using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class AccountOwner : ISubscriber
    {

        public string Name { get; set; }
        public AccountOwner( string name)
        {
            Name = name;
        }

        
        public void Update(string msg)
        {
            Console.WriteLine($"My name is {Name} and I am {this.GetType()} right now I receive update {msg}");
        }
    }
}
