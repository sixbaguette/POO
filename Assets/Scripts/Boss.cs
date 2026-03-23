using UnityEngine;

namespace TP2_Heritage
{
    public class Boss : Enemy
    {
        private Boss(int health, int damage, float speed, float detectionRange) : base(health, damage, speed, detectionRange)
        {
            Health = health;
            Damage = damage;
            Speed = speed;
            DetectionRange = detectionRange;
        }

        void Start()
        {
            base.Start();

            Health = 50;
            Damage = 25;
            Speed = 10;
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
            if (collision.transform.CompareTag("Player"))
                gameObject.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, new Vector3(10, 10, 10), 1);
        }
    }
}