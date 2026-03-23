using UnityEngine;
public class ItemRamassable : Item, IRamassable
{
    public virtual void seFaireRamasser(IRamasser ramasseur)
    {
        //ramasseur.ramasser(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        IRamasser ramasseur = other.GetComponent<IRamasser>();

        if (ramasseur == null)
        {
            return;
        }

        seFaireRamasser(ramasseur);
    }
}
