public class Accolade
{
    Nameable Nameable { get; set; }

    public Accolade(string name, string description)
    {
        Nameable = new Nameable(name, description);
    }

    // Accolade-specific properties and methods can go here
}