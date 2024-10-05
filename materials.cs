//Cold Tin, Heat Copper
//Force Steel, Dark Steel
//Force Iron
//Arcane Gold
//Chemical Pewter
//Thermalitic Bronze
//Etheral Goldiron, arcane/force resist
//Something Lead, magewell amulet

//Iron/Adamant
//Gold/Atantum
//Lead/Rykir
//Silver/Valis

/*Heat Copper - a great conductor in items, also allows lots of heat resistance in armor, reacts averse to runes dealing with cold
Cold Tin - allows cold resistance but reacts averse to runes dealing with heat
Thermalitic Bronze - an alloy of nine parts Heat Copper and one part Cold Tin, a great base to enchant with enhancements of both Heat and Cold resistance
Chemical Pewter - an alloy of mostly Tin, allows up to 150 chemical resistance in armor (five slots)
Force Iron - allows up to 200 force resistance in armor, but has less compatibility with hardness and durability runes
Force Steel - allows up to 100 force resistance in armor, with better hardness/durability properties
Dark Steel - allows at least 50 dark resistance in armor, but may be weak to direct light influence
Arcane Steel - better than normal steel for stat rings, apparently, but wasteful in resources
Heat Steel
Grand Arcane Valis - Has high compatibility with Compression runes.
Grand Arcane Gold -
Grand Arcane Atantum - Great for linking runes and supporting structures
Grand Arcane Steel
Grand Arcane Lead
Grand Thermalitic Bronze - Has greater heat resistance than Thermalitic Bronze.
Aluminum has decent affinity for Lightness runes.[6] Its intrinsic rune is also well aligned with the Mental element and poorly aligned with all others.
Titanium surpasses even steel in the ability to strengthen certain runic enchantments, like durability and hardness.*/

namespace DelveManagerSharp
{
    public class Material
    {
        Nameable Nameable { get; set; }

        public Material(string name, string description)
        {
            Nameable = new Nameable(name, description);
        }

        // Material-specific properties and methods can go here
    }

}
