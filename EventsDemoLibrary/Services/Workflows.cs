using EventsDemoLibrary.Models;

namespace EventsDemoLibrary.Services
{
    internal static class Workflows
    {
        internal static void EventsOverview()
        {
            User user = new User();
            ShoppingService shoppingService = new ShoppingService();

            shoppingService.SellProducts(user.CreditCard, 80m);
            shoppingService.SellProducts(user.CreditCard, 35.69m);
            shoppingService.SellProducts(user.CreditCard, 4m);
            shoppingService.SellProducts(user.CreditCard, 15m);

            user.CreditCard.EventsCleanUp();
        }
    }
}
