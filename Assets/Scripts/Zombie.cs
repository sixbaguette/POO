using UnityEngine;

namespace TP2_Heritage
{
    public class Zombie : Enemy
    {
        private int TriggerRadius;

        private Zombie(int health, int damage, float speed, float detectionRange) : base(health, damage, speed, detectionRange)
        {
            Health = health;
            Damage = damage;
            Speed = speed;
            DetectionRange = detectionRange;
        }

        void Start()
        {
            base.Start();

            Health = 15;
            Damage = 8;
            Speed = 8;
            DetectionRange = 50;

            TriggerRadius = 5;
        }

        void Update()
        {
            base.Update();

            float trigger = Vector3.Distance(Player.transform.position, transform.position);

            if (trigger < this.TriggerRadius)
            {
                for (int i = 0; i < 1; i++)
                {
                    Speed = Speed * 1.2f;
                }
            }
            else if (trigger > this.TriggerRadius)
            {
                Speed = 8;
            }
        }

        private void TakeDamage(int amount)
        {
            base.TakeDamage(amount);
        }

        private void Die()
        {
            base.Die();
        }

        void OnCollisionEnter(Collision collision)
        {
            base.OnCollisionEnter(collision);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, TriggerRadius);
        }
    }
}