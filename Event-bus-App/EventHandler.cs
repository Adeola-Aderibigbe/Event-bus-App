namespace Event_bus_App
{
    public delegate void DelegateEventHandler<T>(T @event) where T : Event;

    public  class EventHandler<T> : IEventHandler<T> where T : Event
    {
        public virtual void Handle(T @event)
        {
            throw new NotImplementedException();
        }
    }
}   

