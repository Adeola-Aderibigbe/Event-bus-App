using Event_bus_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1._0
{
    public class App1EventHandler : Event_bus_App.EventHandler<App2Event>
    {
        public override void Handle(App2Event @event)
        {
            Console.WriteLine(@event.Message);
            Console.WriteLine(@event.TimeStamp.TimeOfDay);
        }
    }
}
