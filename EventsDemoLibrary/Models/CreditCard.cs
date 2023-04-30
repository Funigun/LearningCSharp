using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemoLibrary.Models
{
    internal class CreditCard
    {
        // Event declaration
        internal event EventHandler<string> SuccessfullPaymentEventHandler;
        internal event EventHandler<string> FailedPaymentEventHandler;

        internal string Number { get; private set; }
        internal decimal Balance { get; private set; }

        internal void MakePayment(decimal amount)
        {
            if (Balance - amount > 0.00m)
            {
                Balance -= amount;
                // Triggering event
                SuccessfullPaymentEventHandler?.Invoke(this, $"Payment processed succesfully.");
            }
            else
            {
                // Triggering event
                FailedPaymentEventHandler?.Invoke(this, $"Operation blocked, not enough resources.");
            }
        }

        internal CreditCard()
        {
            Number = "123-456-789";
            Balance = 123.56m;
            // Own event listeners
            SuccessfullPaymentEventHandler += CreditCard_PaymentEventHandler;
            FailedPaymentEventHandler += CreditCard_PaymentEventHandler;
        }

        // Action when event is triggered
        private void CreditCard_PaymentEventHandler(object? sender, string e)
        {
            Console.WriteLine(e);
        }

        internal void EventsCleanUp()
        {
            FailedPaymentEventHandler -= CreditCard_PaymentEventHandler;
            SuccessfullPaymentEventHandler -= CreditCard_PaymentEventHandler;
        }
    }
}
