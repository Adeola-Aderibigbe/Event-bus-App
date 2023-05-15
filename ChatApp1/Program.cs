using App1._0;
using App2._0;
using ChatApp1;
using Event_bus_App;

IEventBus _eventBus = new EventBus();
App2EventHandler eventHandler2 = new();
App1EventHandler eventHandler1 = new();
var handler1 = new DelegateEventHandler<App1Event>(eventHandler2.Handle);
var handler2 = new DelegateEventHandler<App2Event>(eventHandler1.Handle);
_eventBus.SubscribeDynamic(handler1);
_eventBus.SubscribeDynamic(handler2);

EventFactory.ReceiveConnection(_eventBus);

