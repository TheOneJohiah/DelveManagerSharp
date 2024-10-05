public class Entity
{
    Nameable Name { get; set; }

    public Entity(string name, string description)
    {
        Name = new Nameable(name, description);
    }
}
