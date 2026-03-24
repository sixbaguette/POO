
using System.Collections.Generic;

public class Inventory
{
    public List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void RemoveItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items.RemoveAt(index);
        }
    }

    public float GetTotalWeight()
    {
        float totalWeight = 0;
        for (int i = 0; i < items.Count; i++)
        {
            totalWeight += items[i].Weight;
        }
        return totalWeight;
    }
}