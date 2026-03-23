using UnityEngine;

namespace TP2_Heritage
{
    public class Skeleton : Enemy
    {
        private Skeleton(int health, int damage, float speed, float detectionRange) : base(health, damage, speed, detectionRange)
        {
            Health = health;
            Damage = damage;
            Speed = speed;
            DetectionRange = detectionRange;
        }

        void Start()
        {
            base.Start();

            Health = 10;
            Damage = 15;
            Speed = 12;
            DetectionRange = 50;
        }

        void Update()
        {
            base.Update();
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
    }
}