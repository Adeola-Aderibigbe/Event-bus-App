using Event_bus_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2._0
{
    public class ReplyMessages 
    {
        private IEventBus eventBus;
        public ReplyMessages(IEventBus _eventBus)
        {
           eventBus = _eventBus;        
        }

        public void ReplyMessage(string message)
        {
            var @event = new App2Event(message);
            eventBus.Publish(@event);
        }
        
    }
}
