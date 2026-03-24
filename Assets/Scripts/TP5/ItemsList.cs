using System.Collections.Generic;
using UnityEngine;

public class ItemsList : List<Item>
{
    public ItemsList() : base()
    {
        this.Add(new Weapons("sword", "a sword", 10, 1, 8, 3));
        this.Add(new Helmet("helmet", "a helmet", 25, 1, 15));
        this.Add(new Chest("chest", "a chest", 35, 1, 20));
        this.Add(new Boots("boots", "some boots", 15, 1, 10));
        this.Add(new Boots("boots2", "some boots", 15, 1, 10));
    }

    public int TotalCount()
    {
        return this.Count;
    }

    public Item GetItem(string itemName)
    {
        for (int i = 0; i < this.Count; i++)
        {
            if (this[i].Name == itemName)
            {
                return this[i];
            }

            foreach (var item in this[i].Name)
            {
                Debug.Log(item);
            }
        }

        return null;
    }
}
