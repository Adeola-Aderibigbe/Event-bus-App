using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_bus_App
{
    public class Event
    {
        public Event(string message)
        {
            Message = message;
            TimeStamp = DateTime.Now;
        }
        public string Message { get; protected set; } 
        public DateTime TimeStamp { get; protected set; }
    }
}
