using App1._0;
using App2._0;
using Event_bus_App;

IEventBus _eventBus = new EventBus();
_eventBus.Subscribe<Event, App2EventHandler>(new App2EventHandler());
var sendMessages = new SendMessages(_eventBus);
sendMessages.SendMessage("Hello from App1.0");

