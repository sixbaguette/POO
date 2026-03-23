using UnityEngine;

public class Arc : Weapon
{
    public override void Attack()
    {
        // Logique d'attaque � l'arc
        Debug.Log("Firing arrow");

        // Cr�ation d'une fl�che
        GameObject arrowPrefab = Resources.Load<GameObject>("Arrow");
        if (arrowPrefab != null)
        {
            GameObject arrow = Instantiate(arrowPrefab, transform.position + transform.forward, Quaternion.identity);
            Rigidbody rb = arrow.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = transform.forward * 20f;
            }
        }
    }
}
