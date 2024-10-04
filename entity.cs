public class Entity
{
    Nameable Nameable { get; set; }

    public Entity(string name, string description)
    {
        Nameable = new Nameable(name, description);
    }
}
