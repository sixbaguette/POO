using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private string playerName;
    [SerializeField]
    private int health;
    [SerializeField]
    private int maxHealth;

    public int Health => health;
    public int MaxHealth => maxHealth;
    public string PlayerName => playerName;

    public Inventory inventory = new Inventory();
    public Equipement equipement = new Equipement();

    public void HealPlayer(int amount)
    {
        health = Mathf.Min(health + amount, maxHealth);
        Debug.Log($"heal");
    }

    public void PlayerAttack(int damage)
    {
        Debug.Log($"attack");
    }
}