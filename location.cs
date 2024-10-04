public class Location
{
    Nameable Nameable { get; set; }

    public Location(string name, string description)
    {
        Nameable = new Nameable(name, description);
    }

    // Location-specific properties and methods can go here
}
