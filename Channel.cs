using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._zadatak
{
    public interface Channel
    {
        void Add(INotifiable notifiable);
        void Remove(INotifiable notifiable);
        void Notify(string message);
    }
}
