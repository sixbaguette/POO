public class Helmet : Armor
{
    public Helmet(string name, string description, float weight, int value, int defense) : base(name, description, weight, value, defense)
    {

    }

    public override Equipement.slotType getSlot()
    {
        return Equipement.slotType.HELMET;
    }
}