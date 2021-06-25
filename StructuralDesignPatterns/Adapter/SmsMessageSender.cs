using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class SmsMessageSender
    {
        public void SendMessage(int phoneNumber, string message)
        {
            Console.WriteLine($"Send message: \"{message}\" to number:  {phoneNumber} by Sms Message Sender");
        }
    }
}
