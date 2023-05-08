using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_bus_App
{
    public interface IEventBus : IDisposable
    {
        void Dispose();
        void Publish<T>(T @event) where T : Event;
        void Subscribe<T,EH>(EH eH) where T : Event
            where EH : IEventHandler;
    }
}
