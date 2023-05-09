using Event_bus_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_bus_App
{
    public class App1Event : Event
    {
        public App1Event(string message) : base(message)
        {
        }
    }
}
