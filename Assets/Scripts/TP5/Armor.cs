public abstract class Armor : Item, IUseItem, IItemEquipable
{
    private int defense;
    public int Defense
    {
        get { return defense; }
        set { defense = value; }
    }

    public Armor(string name, string description, float weight, int value, int defense) : base(name, description, weight, value)
    {
        this.defense = defense;
    }

    public virtual void UseItem(Player player)
    {
        player.equipement.EquipItems(this);
    }

    public abstract Equipement.slotType getSlot();
}