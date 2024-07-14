using Units.Interfaces;
using UnityEngine;

namespace Units.UnitSystems
{
    public class MeleeAttack : MonoBehaviour, IAttack
    {
        public void Attack(int damage)
        {
            Debug.Log("Melee damage dealt: " + damage);
        }
    }
}