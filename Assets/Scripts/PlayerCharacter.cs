using UnityEngine;

namespace TP1_Encapsulation
{
    public class PlayerCharacter : MonoBehaviour
    {
        // Toutes les données sont publiques et peuvent être modifiées n'importe où
        [SerializeField]
        private string playerName;

        [SerializeField]
        private int health;
        public int Health
        {
            get { return health; }
        }

        [SerializeField]
        [Range(0, 100)]
        private int maxHealth;

        public int MaxHealth
        {
            set { maxHealth = value; }
        }

        [SerializeField]
        [Range(0, 25)]
        private float moveSpeed;

        public float MoveSpeed
        {
            get { return moveSpeed; }
            set
            {
                moveSpeed = Mathf.Clamp(value, 0f, 25f);
            }
        }

        [SerializeField]
        private int gold;
        public int Gold
        {
            get { return gold; }
        }

        [SerializeField]
        private bool isInvincible;

        public bool IsInvincible
        {
            get { return isInvincible; }
            set { isInvincible = value; }
        }

        void Update()
        {
            // Le personnage peut avoir une santé négative car rien ne l'empêche
            if (health <= 0)
            {
                Debug.Log("Player is dead");
                return;
            }

            // La vitesse peut être modifiée à n'importe quelle valeur
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        public void GainGold(int amount)
        {
            if (amount < 0)
            {
                return;
            }
            else
            {
                gold += amount;
            }
        }

        public void LoseGold(int amount)
        {
            if (amount < 0 || gold < amount)
            {
                return;
            }
            else
            {
                gold -= amount;
            }
        }

        // Méthode nécessaire pour les autres TPs, mais mal implémentée
        public void TakeDamage(int amount)
        {
            if (isInvincible) return;
            if (health < amount)
            {
                health = 0;
            }
            else
            {
                health -= amount;
            }
        }
    }
}