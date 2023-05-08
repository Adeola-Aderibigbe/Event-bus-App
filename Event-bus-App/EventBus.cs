using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_bus_App
{
    public class EventBus : IEventBus
    {
        List<IEventHandler> subscribers = new();
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Publish<T>(T @event) where T : Event
        {
            if (@event == null) return;

            foreach (var subscriber in subscribers)
            {
                subscriber.Handle(@event);
            }
        }

        public void Subscribe<T, EH>(EH eH)
            where T : Event
            where EH : IEventHandler
        {
           subscribers.Add(eH);
        }
    }
}
