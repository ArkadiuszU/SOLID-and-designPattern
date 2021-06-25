using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class EmailMessageSender : ISender
    {
        List<User> users = new List<User>();
        public EmailMessageSender(List<User> users)
        {
            this.users = users;
        }

        public void SendMessage(int userId, string message)
        {
            var user = users.FirstOrDefault(u => u.Id == userId);
            Console.WriteLine($"Send message: \"{message}\" to: {user.Name} by Email Message Sender");
        }
    }
}
