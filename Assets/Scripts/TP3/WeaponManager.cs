using UnityEngine;

namespace TP3_Polymorphisme
{
    public class WeaponManager : MonoBehaviour
    {
        [SerializeField] private Arc bow;
        [SerializeField] private Epee sword;
        [SerializeField] private Wand wand;

        private Weapon weapon;

        private int weapons;

        private void Start()
        {
            SwitchWeapon();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                weapons = (weapons + 1) % 3;
                SwitchWeapon();
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (weapon != null)
                {
                    weapon.Attack();
                }
            }
        }

        public void SwitchWeapon()
        {
            switch (weapons)
            {
                case (0):
                    weapon = bow;
                    break;
                case (1):
                    weapon = sword;
                    break;
                case (2):
                    weapon = wand;
                    break;
            }
            if (weapon != null)
            {
                Debug.Log("Weapon : " + weapon.Id);
            }
        }
    }
}