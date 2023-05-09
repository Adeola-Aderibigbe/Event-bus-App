using Event_bus_App;
namespace App1._0
{
    public class SendMessages
    {
        private readonly IEventBus eventBus;
        public SendMessages(IEventBus _eventBus)
        {
            eventBus = _eventBus;
        }

        public void SendMessage(string message)
        {
            var @event = new App1Event(message);
            eventBus.Publish(@event);
        }
    }
}
