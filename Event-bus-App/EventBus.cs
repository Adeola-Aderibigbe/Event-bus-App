using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_bus_App
{
    public class EventBus : IEventBus
    {
        Dictionary<Type, EventHandler<Event>> subscribers1 = new();
        Dictionary<Type, List<Delegate>> subscribers2 = new();
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
                subscriber.Value?.Handle(@event);
            }

            var currentSubscribers2 = subscribers2[typeof(T)];
            foreach (var subscriber in currentSubscribers2)
            {
                //  ((IEventHandler)subscriber).Handle(@event);

                ((DelegateEventHandler<T>)subscriber)(@event);
            }
        }

        public void Subscribe<T, EH>(EH handler)
            where T : Event
            where EH : EventHandler<T>
        {
            var handler1 = handler as EventHandler<Event>;
           subscribers1.Add(typeof(T),handler as EventHandler<Event>);
        }
        
        public void SubscribeDynamic<T>(DelegateEventHandler<T> handler) 
            where T: Event
        {
            if (handler == null) return;
            if (!subscribers2.ContainsKey(typeof(T)))
            {
                subscribers2.Add(typeof(T),new List<Delegate>());
            }
           
            subscribers2[typeof(T)].Add(handler);
        }
    }
}
