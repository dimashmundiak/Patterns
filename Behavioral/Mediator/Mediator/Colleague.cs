namespace Mediator
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        protected Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }

        public virtual void Send(string message)
        {
            Mediator.Send(message, this);
        }
        public abstract void Notify(string message);
    }
}