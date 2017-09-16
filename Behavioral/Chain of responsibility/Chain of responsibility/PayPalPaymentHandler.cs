using System;

namespace Chain_of_responsibility
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer)
                Console.WriteLine("Выполняем перевод через PayPal");
            else
            {
                Successor?.Handle(receiver);
            }
        }
    }
}
