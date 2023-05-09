using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_bus_App
{
    public interface IEventHandler<T> where T : Event 
    {
        void Handle(T @event);
    }
}
