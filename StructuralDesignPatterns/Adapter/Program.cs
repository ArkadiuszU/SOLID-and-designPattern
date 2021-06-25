using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

             List<User> users = new List<User> {
             new User { Id = 1, Name= "Jim", Email = "jim@sample.com", PhoneNumber=123456123},
             new User { Id = 2, Name= "Tom", Email = "tom@sample.com", PhoneNumber=222333444},
             new User { Id = 3, Name= "Kate", Email = "kate@sample.com", PhoneNumber=987654321}
             };

            ISender messageSender = new EmailMessageSender(users);
            ISender messageSender2 = new SmsSenderAdapter(users); 

            messageSender.SendMessage(1, "Hi first user");
            messageSender2.SendMessage(2, "Hello :)");



        }
    }
}
