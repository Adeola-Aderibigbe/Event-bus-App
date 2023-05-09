using Event_bus_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_bus_App
{
    public class App2Event : Event
    {
        public App2Event(string message) : base(message)
        {
        }
    }
}
