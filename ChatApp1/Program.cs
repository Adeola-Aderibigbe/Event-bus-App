using App1._0;
using App2._0;
using Event_bus_App;

IEventBus _eventBus = new EventBus();
_eventBus.Subscribe<App1Event, App2EventHandler>(new App2EventHandler());
_eventBus.Subscribe<App2Event, App1EventHandler>(new App1EventHandler());
var sendMessages = new SendMessages(_eventBus);
var replyMessages = new ReplyMessages(_eventBus);
sendMessages.SendMessage("Hello from App 1.0");
replyMessages.ReplyMessage("Hello App 1.0, I am App 2.0");

