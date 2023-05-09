using Event_bus_App;
using System;

delegate void DelegateEventHandler<T>(T @event) where T : Event;
namespace Event_bus_App
{
    public class EventHandler
    {
        public virtual void Handler<T>(T @event)
        {
            Console.WriteLine($"{typeof(T)} is been handled");
        }
    }
}

