using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class NetflixNotificationPublisher
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();

        public void AddSubscriber(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void SendNotification(string msg)
        {
            if (! (subscribers is null))
            {
                foreach (ISubscriber item in subscribers)
                {
                    item.Update(msg);
                }
            }
        }
    }
}
