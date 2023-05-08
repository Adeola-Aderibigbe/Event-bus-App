using Event_bus_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp2
{
    public class ChatEventHandler : IEventHandler
    {
        public void Handle<T>(T @event) where T : Event
        {
           Console.WriteLine(@event.Message);
        }
    }
}
