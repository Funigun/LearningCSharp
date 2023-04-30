using EventsDemoLibrary.Services;

namespace EventsDemoLibrary
{
    public static class Menu
    {
        public static Dictionary<int, string> MenuList { get; private set; } = new Dictionary<int, string>()
        {
            { 1, "1 - Events overview" },
        };

        public static Dictionary<int, Action> MenuActions { get; private set; } = new Dictionary<int, Action>()
        {
            { 1, Workflows.EventsOverview },
        };
    }
}
