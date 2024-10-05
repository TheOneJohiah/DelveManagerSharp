

namespace DelveManagerSharp
{
    public class Entity
    {
        public Nameable Nameable { get; set; }

        public Entity(string name, string description)
        {
            Nameable = new Nameable(name, description);
        }
    }

}