using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_bus_App
{
    public class EventBus : IEventBus
    {
        Dictionary<Type, IEventHandler> subscribers1 = new();
        Dictionary<Type, DelegateEventHandler<Event>> subscribers2 = new();
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Publish<T>(T @event) where T : Event
        {
            if (@event == null) return;

            var currentSubscribers = subscribers1.Where(s => s.Key == @event.GetType());
            foreach (var subscriber in currentSubscribers)
            {
                subscriber.Value.Handle(@event);
            }
        }

        public void Subscribe<T, EH>(EH eH)
            where T : Event
            where EH : IEventHandler
        {

           subscribers1.Add(typeof(T),eH);
        }
    }
}
