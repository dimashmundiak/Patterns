using System;
using System.Collections.Generic;

namespace Composite
{
    public class Directory : Component
    {
        private readonly List<Component> _components = new List<Component>();

        public Directory(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine("Узел " + Name);
            Console.WriteLine("Подузлы:");
            for (int i = 0; i < _components.Count; i++)
            {
                _components[i].Print();
            }
        }
    }
}
