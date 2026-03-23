using TP3_Polymorphisme;
using UnityEngine;

public class Wand : Weapon
{
    public override void Attack()
    {
        // Logique d'attaque � la baguette
        Debug.Log("Casting spell");

        // V�rifier si le joueur a assez de mana
        PlayerCharacterTP3 player = GetComponent<PlayerCharacterTP3>();
        if (player != null && player.SpendMana(15f))
        {
            // Cr�ation d'un projectile magique
            GameObject spellPrefab = Resources.Load<GameObject>("Spell");
            if (spellPrefab != null)
            {
                GameObject spell = Instantiate(spellPrefab, transform.position + transform.forward, Quaternion.identity);
                spell.GetComponent<Rigidbody>().linearVelocity = transform.forward * 15f;
            }
        }
        else
        {
            Debug.Log("Not enough mana!");
        }
    }
}
