public class Chest : Armor
{
    public Chest(string name, string description, float weight, int value, int defense) : base(name, description, weight, value, defense)
    {

    }

    public override Equipement.slotType getSlot()
    {
        return Equipement.slotType.CHEST;
    }
}