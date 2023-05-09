using Event_bus_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2._0
{
    public class App2EventHandler : Event_bus_App.EventHandler<App1Event>
    {

        public override void Handle(App1Event @event)
        {
            Console.WriteLine(@event.Message);
            Console.WriteLine(@event.TimeStamp.TimeOfDay);
        }
    }
}
