using EventsDemoLibrary.Models;

namespace EventsDemoLibrary.Services
{
    internal class ShoppingService
    {
        private void ShoppingService_BlockSellingProductsEvent(object? sender, string e)
        {
            Console.WriteLine("Restoring shopping card available items.");
        }

        internal void SellProducts(CreditCard creditCard, decimal cartValue)
        {
            // Adding outside event listener
            creditCard.FailedPaymentEventHandler += ShoppingService_BlockSellingProductsEvent;

            creditCard.MakePayment(cartValue);

            // Removing outside event listener
            creditCard.FailedPaymentEventHandler -= ShoppingService_BlockSellingProductsEvent;
        }
    }
}
