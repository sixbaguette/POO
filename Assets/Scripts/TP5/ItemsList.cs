using System.Collections.Generic;

public class ItemsList : List<Item>
{
    public ItemsList() : base()
    {
        this.Add(new Weapons("sword", "a sword", 10, 1, 8, 3));
        this.Add(new Helmet("helmet", "a helmet", 25, 1, 15));
        this.Add(new Chest("chest", "a chest", 35, 1, 20));
        this.Add(new Boots("boots", "some boots", 15, 1, 10));
    }

    private void Counter()
    {

    }
}
