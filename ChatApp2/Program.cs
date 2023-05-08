using ChatApp2;
using Event_bus_App;

IEventBus _eventBus = new EventBus();

_eventBus.Subscribe<Event,ChatEventHandler>(new ChatEventHandler());
