using System;

namespace Composite
{
    public abstract class Component
    {
        protected string Name;

        protected Component(string name)
        {
            Name = name;
        }

        public virtual void Add(Component component)
        {
        }

        public virtual void Remove(Component component)
        {
        }

        public virtual void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
