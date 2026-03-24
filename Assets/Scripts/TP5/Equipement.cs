public class Equipement
{
    public enum slotType { WEAPON, HELMET, CHEST, BOOTS };

    public Weapons EquippedWeapon { get; private set; }
    public Helmet EquippedHelmet { get; private set; }
    public Chest EquippedChest { get; private set; }
    public Boots EquippedBoots { get; private set; }

    public IItemEquipable[] itemEquip;

    public void EquipItems(IItemEquipable item)
    {
        if (itemEquip == null) itemEquip = new IItemEquipable[System.Enum.GetValues(typeof(slotType)).Length];

        itemEquip[(int)item.getSlot()] = item;
    }
}