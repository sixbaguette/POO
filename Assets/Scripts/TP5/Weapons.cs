public class Weapons : Item, IUseItem, IItemEquipable
{
    private int damage;
    private Equipement.slotType slot = Equipement.slotType.WEAPON;
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }
    private float range;
    public float Range
    {
        get { return range; }
        set { range = value; }
    }

    public Weapons(string name, string description, float weight, int value, int damage, float range) : base(name, description, weight, value)
    {
        this.damage = damage;
        this.range = range;
    }

    public void UseItem(Player player)
    {
        player.equipement.EquipItems(this);
    }

    public Equipement.slotType getSlot()
    {
        return Equipement.slotType.WEAPON;
    }
}