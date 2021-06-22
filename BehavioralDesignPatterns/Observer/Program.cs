using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AccountOwner accountOwner = new AccountOwner("Jim");
            AccountUser accountUser1 = new AccountUser("Tom");
            AccountUser accountUser2 = new AccountUser("Jack");

            NetflixNotificationPublisher publisher = new NetflixNotificationPublisher();

            publisher.SendNotification("First message");

            publisher.AddSubscriber(accountOwner);
            publisher.AddSubscriber(accountUser1);
            publisher.AddSubscriber(accountUser2);

            publisher.SendNotification("another message");

            publisher.RemoveSubscriber(accountUser1);

            publisher.SendNotification("last message");

        }
    }
}
