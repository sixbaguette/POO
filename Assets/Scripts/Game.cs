using UnityEngine;

public class Game : MonoBehaviour
{
    Arme arc;
    Arme epee;

    private void Start()
    {
        arc = new Arme("arc", "arc ancient", 10, 100);
        arc.Attaquer();

        epee = new Arme("épée", "épée ancienne", 6, 150);
        epee.Attaquer();

        ArmeMelee epee2 = new ArmeMelee("épée2", "épée2 ancienne", 8, 200);
    }
}
