using TP1_Encapsulation;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    protected int Health { set; get; }

    [SerializeField]
    protected int Damage { set; get; }

    [SerializeField]
    protected float Speed { set; get; }

    [SerializeField]
    protected float DetectionRange { set; get; }

    protected Transform Player;

    public Enemy(int health, int damage, float speed, float detectionRange)
    {
        Health = health;
        Damage = damage;
        Speed = speed;
        DetectionRange = detectionRange;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        Destroy(gameObject);
    }

    protected void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    protected void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) < DetectionRange)
        {
            Vector3 direction = (Player.position - transform.position).normalized;
            transform.position += direction * Speed * Time.deltaTime;
        }
    }

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerCharacter player = collision.gameObject.GetComponent<PlayerCharacter>();
            if (player != null)
            {
                player.TakeDamage(Damage);
            }
        }
    }
}
