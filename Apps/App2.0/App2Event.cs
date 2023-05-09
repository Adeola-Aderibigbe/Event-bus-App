using Event_bus_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2._0
{
    public class App2Event : Event
    {
        public App2Event(string message) : base(message)
        {
        }
    }
}
