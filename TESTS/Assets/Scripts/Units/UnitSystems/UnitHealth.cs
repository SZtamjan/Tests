using Units.Interfaces;
using UnityEngine;

namespace Units.UnitSystems
{
    public class UnitHealth : MonoBehaviour, IHealth
    {
        public int Health { get; set; }

        public void GetDamage(int damage)
        {
            Debug.Log("Damage taken: " + damage);
        }
    }
}