using UnityEngine;

public class Arme
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Degat { get; set; }
    public int Durabilite { get; set; }

    //getter 
    public string getName()
    {
        return Name;
    }

    //setter
    public void setName(string valeur)
    {
        Name = valeur;
    }

    public Arme(string name, string description, int degat, int durabilite)
    {
        Name = name;
        Description = description;
        Degat = degat;
        Durabilite = durabilite;
    }

    public void Attaquer()
    {
        Debug.Log($"{Name} + {Description} + {Degat} + {Durabilite}");
    }
}