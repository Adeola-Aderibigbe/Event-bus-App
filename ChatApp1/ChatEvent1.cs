using Event_bus_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp1
{
    public class ChatEvent1 : Event
    {
        public ChatEvent1(string message) : base(message)
        {
        }
    }
}
