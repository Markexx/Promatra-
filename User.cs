using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._zadatak
{
    public class User : INotifiable
    {
        public void PushNotification(string message)
        {
            Console.WriteLine(message);
        }
    }
}
