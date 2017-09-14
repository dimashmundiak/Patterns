using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank = new Bank("ЮнитБанк", stock);
            Broker broker = new Broker("Иван Иваныч", stock);
            stock.Market();
            broker.StopTrade();
            stock.Market();

            Console.Read();
        }
    }
}
