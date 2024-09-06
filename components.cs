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

//Do we actually need this as a specific class?
//Do all Hardness things have Sharpness too?
//No! Some monsters have Hardness, or armors
//CreatureArmor class that pulls this as like an array, probably?
//Since some creatures' armor is dependent on what part of their body is hit
class Hardened
{
    public int Hardness { get; set; }

    public Hardened(int hardness)
    {
        Hardness = hardness;
    }
}

class Sharpened
{
    public int Sharpness { get; set; }

    public Sharpened(int sharpness)
    {
        Sharpness = sharpness;
    }
}


//All things with saturation have dissipation
class Absorbable
{
    public int Saturation { get; set; }
    public int CurrentSaturation  { get; set; }
    public int Dissipation { get; set; }
    public int Absorption { get; set; } //ranges from 1 to 99% for conversion of incoming damage

    public Absorbable(int saturation, int dissipation, int absorption)
    {
        Saturation = saturation;
        CurrentSaturation = 0;
        Dissipation = dissipation;
        Absorption = absorption;
    }

    public int Absorb(int incomingDamage)
    {
        int remainingDamage; //for sending damage back out
        // Calculate the actual mana absorbed based on efficiency
        int addedSaturation = incomingDamage * Absorption / 100;
        remainingDamage = incomingDamage - addedSaturation;

        int leakedDamage = addedSaturation + CurrentSaturation - Saturation;
        if(leakedDamage > 0) {
            CurrentSaturation = CurrentSaturation;
            
            remainingDamage = remainingDamage + leakedDamage;
            return remainingDamage; //leaked damage plus excess over saturation
        }

        return remainingDamage; //leaked damage, saturation cap not exceeded
    }
}

//Base class for all Use things, like Using a key, Using a potion
abstract class Use
{
    public abstract void Execute(Entity user, Entity target);
}