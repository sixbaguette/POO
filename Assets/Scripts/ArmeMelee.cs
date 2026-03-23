using UnityEngine;
public class ArmeMelee : Arme
{
    public ArmeMelee(int id, int degat, int range) : base(id, degat, range)
    {
        Id = id;
        Degat = degat;
        Range = range;
    }

    public override void attaquer()
    {
        Debug.Log("attaque épée");
    }
}
