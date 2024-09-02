class Nameable
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Nameable(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void Rename(string newName)
    {
        Name = newName;
    }

    public void UpdateDescription(string newDescription)
    {
        Description = newDescription;
    }
}

//Base class for all Use things, like Using a key, Using a potion
abstract class Use
{
    public abstract void Execute(Entity user, Entity target);
}
