using UnityEngine;

public class Potions : Item, IUseItem
{
    private int healthRestored;
    public int HealthRestored
    {
        get { return healthRestored; }
        set { healthRestored = value; }
    }
    private float duration;
    public float Duration
    {
        get { return duration; }
        set { duration = value; }
    }

    public Potions(string name, string description, float weight, int value, int healthRestored, float duration) : base(name, description, weight, value)
    {
        this.healthRestored = healthRestored;
        this.duration = duration;
    }

    public void UseItem(Player player)
    {
        player.HealPlayer(healthRestored);
        Debug.Log($"{player.PlayerName} utilise {Name}.");
    }
}