using UnityEngine;

public abstract class Weapon : MonoBehaviour, IWeapon
{
    [SerializeField] private string id;
    public string Id
    {
        get { return id; }
    }

    public abstract void Attack();
}
