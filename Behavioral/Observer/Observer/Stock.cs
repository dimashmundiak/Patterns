using System;
using System.Collections.Generic;

namespace Observer
{
    public class Stock : IObservable
    {
        private readonly StockInfo _sInfo;
        private readonly List<IObserver> _observers;

        public Stock()
        {
            _sInfo = new StockInfo();
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in _observers)
            {
                o.Update(_sInfo);
            }
        }

        public void Market()
        {
            Random rnd = new Random();
            _sInfo.USD = rnd.Next(20, 40);
            _sInfo.Euro = rnd.Next(30, 50);
            NotifyObservers();
        }
    }
}
