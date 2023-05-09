using Event_bus_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1._0
{
    public class App1EventHandler : IEventHandler
    {
        public void Handle<T>(T @event) where T : Event
        {
            Console.WriteLine(@event.Message);
            Console.WriteLine(@event.TimeStamp.TimeOfDay);
        }
    }
}
