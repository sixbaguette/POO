using UnityEngine;

public class Epee : Weapon
{
    public override void Attack()
    {
        // Logique d'attaque � l'�p�e
        Debug.Log("Swinging sword");
        // Animation, effets sonores, etc.

        // D�tection des ennemis � proximit�
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 2f);
        foreach (var hitCollider in hitColliders)
        {
            Enemy enemy = hitCollider.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(25);
            }
        }
    }
}
