using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._zadatak
{
    public class Creator : Channel
    {
        List<INotifiable> notifiables;

        public Creator()
        {
            notifiables = new List<INotifiable>();
        }

        public void Add(INotifiable notifiable)
        {
            notifiables.Add(notifiable);
        }

        public void Remove(INotifiable notifiable)
        {
            notifiables.Remove(notifiable);
        }

        public void Notify(string message)
        {
            foreach (INotifiable notifiable in notifiables)
            {
                notifiable.PushNotification(message);
            }
        }
    }
}
