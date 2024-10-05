
namespace DelveManagerSharp
{
    public class Monster : Entity
    {
        public List<Attack> Attacks { get; set; }

        public Monster(string name, string description, List<Attack> attacks) : base(name, description)
        {
            Attacks = attacks;
            //Skills = new Skills();
        }


        // Additional functionality specific to Monsters can go here
    }

}
