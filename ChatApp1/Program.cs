
using ChatApp1;
using Event_bus_App;

IEventBus _eventBus = new EventBus();

ChatBot("Hello");

void ChatBot(string message)
{
    var @event = new ChatEvent1(message);
    _eventBus.Publish(@event);

}
