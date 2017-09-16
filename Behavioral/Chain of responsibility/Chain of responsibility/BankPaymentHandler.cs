using System;

namespace Chain_of_responsibility
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer)
                Console.WriteLine("Выполняем банковский перевод");
            else
            {
                Successor?.Handle(receiver);
            }
        }
    }
}
