using System;

namespace Observer
{
    public class Bank : IObserver
    {
        public string Name { get; set; }
        readonly IObservable _stock;
        public Bank(string name, IObservable obs)
        {
            this.Name = name;
            _stock = obs;
            _stock.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.Euro > 40)
                Console.WriteLine($"Банк {Name} продает евро;  Курс евро: {sInfo.Euro}");
            else
                Console.WriteLine($"Банк {Name} покупает евро;  Курс евро: {sInfo.Euro}");
        }
    }
}
