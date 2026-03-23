using TP1_Encapsulation;
using UnityEngine;

public class Joueur : MonoBehaviour, IDamageable, IRamasser
{
    private int id;
    private int vie;
    private int vitesseCourse;

    private float horizontalInput;
    private float verticalInput;

    private PlayerCharacter playerCharacter;
    private Rigidbody rb;
    private Arme armeEquipee;

    public Joueur(int id, int vie, int vitesseCourse)
    {
        this.id = id;
        this.vie = vie;
        this.vitesseCourse = vitesseCourse;
    }

    private void Awake()
    {
        playerCharacter = GetComponent<PlayerCharacter>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        seDeplacer();
    }

    public void seDeplacer()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    public void attaquer()
    {
        if (armeEquipee == null) return;

        armeEquipee.attaquer();
    }

    public void prendreDegats()
    {
        throw new System.NotImplementedException();
    }

    public void ramasser(IRamassable item)
    {
        Debug.Log("a ramasser");
        item.seFaireRamasser(this);
    }

    public void equiper(Arme arme)
    {
        Debug.Log("et équiper");
        armeEquipee = arme;
    }

    private void FixedUpdate()
    {
        if (playerCharacter.Health <= 0) return;

        Move();
    }

    private void Move()
    {
        // Utiliser la vitesse de d�placement du PlayerCharacter
        float currentSpeed = playerCharacter.MoveSpeed;

        // Mouvement pour un jeu 3D
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput).normalized * currentSpeed;
        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);

        // Rotation du personnage dans la direction du mouvement (pour 3D)
        if (movement.x != 0 || movement.z != 0)
        {
            transform.rotation = Quaternion.LookRotation(new Vector3(movement.x, 0, movement.z));
        }
    }
}
