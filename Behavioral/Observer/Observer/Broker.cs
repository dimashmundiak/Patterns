using System;

namespace Observer
{
    public class Broker : IObserver
    {
        public string Name { get; set; }
        IObservable _stock;
        public Broker(string name, IObservable obs)
        {
            this.Name = name;
            _stock = obs;
            _stock.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.USD > 30)
                Console.WriteLine($"Брокер {this.Name} продает доллары;  Курс доллара: {sInfo.USD}");
            else
                Console.WriteLine($"Брокер {this.Name} покупает доллары;  Курс доллара: {sInfo.USD}");
        }
        public void StopTrade()
        {
            _stock.RemoveObserver(this);
            _stock = null;
        }
    }
}
