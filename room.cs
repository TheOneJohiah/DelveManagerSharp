public class Room
{
    Nameable Nameable { get; set; }

    public Room(string name, string description)
    {
        Nameable = new Nameable(name, description);
    }

    // Room-specific properties and methods can go here
}
