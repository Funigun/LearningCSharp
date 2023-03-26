namespace TypeSystemDemoLibrary
{
    internal class Employee
    {
        internal string Name { get; set; }
        internal string Position { get; set; }

        internal Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public override string ToString() => $"{Name} - {Position}";
    }
}
