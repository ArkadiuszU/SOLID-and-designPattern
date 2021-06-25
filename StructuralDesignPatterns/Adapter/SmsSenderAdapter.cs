using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class SmsSenderAdapter : ISender
    {
        private readonly List<User> users;
        private readonly SmsMessageSender smsMessageSender;

        public SmsSenderAdapter(List<User> users)
        {
            this.users = users;
            this.smsMessageSender = new SmsMessageSender();
        }
        public void SendMessage(int userId, string message)
        {
            var user = users.FirstOrDefault(u => u.Id == userId);
            smsMessageSender.SendMessage(user.PhoneNumber, message);
            Console.WriteLine($"Send message: \"{message}\" to: {user.Name} by SMS Sender Adapter");
        }
    }
}
