using UnityEngine;

public class ArmeLongueRange : Arme
{
    public ArmeLongueRange(int id, int degat, int range) : base(id, degat, range)
    {
        Id = id;
        Degat = degat;
        Range = range;
    }

    public override void attaquer()
    {
        Debug.Log("attaque arc");
    }
}
