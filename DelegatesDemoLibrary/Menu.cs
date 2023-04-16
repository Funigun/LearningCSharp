using DelegatesDemoLibrary.Services;

namespace DelegatesDemoLibrary
{
    public static class Menu
    {
        public static Dictionary<int, string> MenuList { get; private set; } = new Dictionary<int, string>()
        {
            { 1, "1 - Custom delegate" },
            { 2, "2 - Built-in Action delegate" },
            { 3, "3 - Built-in Func delegate" }
        };

        public static Dictionary<int, Action> MenuActions { get; private set; } = new Dictionary<int, Action>()
        {
            { 1, Workflows.CustomDelegateOverview },
            { 2, Workflows.ActionDelegateOverview },
            { 3, Workflows.FuncDelegateOverview },
        };
    }
}
