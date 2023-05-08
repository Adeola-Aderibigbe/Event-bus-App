
using ChatApp1;
using ChatApp2;
using Event_bus_App;

IEventBus _eventBus = new EventBus();
_eventBus.Subscribe<Event, ChatEventHandler>(new ChatEventHandler());
ChatBot("Hello");

void ChatBot(string message)
{
    var @event = new ChatEvent1(message);
    _eventBus.Publish(@event);

}
