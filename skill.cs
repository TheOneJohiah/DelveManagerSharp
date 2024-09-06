public class Skill
{
    Nameable Nameable { get; set; }

    public Skill(string name, string description)
    {
        Nameable = new Nameable(name, description);
    }

    // Skill-specific properties and methods can go here
}
