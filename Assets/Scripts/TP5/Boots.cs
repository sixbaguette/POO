public class Boots : Armor
{
    public Boots(string name, string description, float weight, int value, int defense) : base(name, description, weight, value, defense)
    {

    }

    public override Equipement.slotType getSlot()
    {
        return Equipement.slotType.BOOTS;
    }
}