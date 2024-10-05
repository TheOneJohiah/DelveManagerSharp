namespace DelveManagerSharp
{
    public class Item
    {
        Nameable Nameable { get; set; }

        public Item(string name, string description)
        {
            Nameable = new Nameable(name, description);
        }

        // Item-specific properties and methods can go here
    }
}