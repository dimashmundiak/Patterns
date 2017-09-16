using System;

namespace Chain_of_responsibility
{
    public class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer)
                Console.WriteLine("Выполняем перевод через системы денежных переводов");
            else
            {
                Successor?.Handle(receiver);
            }
        }
    }
}
