using App1._0;
using App2._0;
using Autofac;
using ChatApp1;
using Event_bus_App;

var containerBuilder = new ContainerBuilder();
containerBuilder.RegisterType<EventBus>().As<IEventBus>();

containerBuilder.RegisterType<App1EventHandler>();
containerBuilder.RegisterType<App2EventHandler>();


containerBuilder.RegisterType<EventFactory>();

var container = containerBuilder.Build();
using (var scope = container.BeginLifetimeScope())
{
    var eventFactory = scope.Resolve<EventFactory>();
    App1EventHandler eventHandler1 = scope.Resolve<App1EventHandler>();
    var eventHandler2 = scope.Resolve<App2EventHandler>();

    var handler1 = new DelegateEventHandler<App1Event>(eventHandler2.Handle);
    var handler2 = new DelegateEventHandler<App2Event>(eventHandler1.Handle);

    eventFactory.EventBus.SubscribeDynamic(handler1);
    eventFactory.EventBus.SubscribeDynamic(handler2);

    eventFactory.ReceiveConnection();
}
  


