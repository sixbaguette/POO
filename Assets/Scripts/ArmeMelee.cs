public class ArmeMelee : Arme
{


    public ArmeMelee(string name, string description, int degat, int durabilite) : base(name, description, degat, durabilite)
    {
        Name = name;
        Description = description;
        Degat = degat;
        Durabilite = durabilite;
    }

    public void Attaquer()
    {
        base.Attaquer();
    }
}
