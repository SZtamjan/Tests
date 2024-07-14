using Units.Interfaces;
using UnityEngine;

namespace Units.UnitSystems
{
    public class RangeAttack : MonoBehaviour, IAttack
    {
        public void Attack(int damage)
        {
            Debug.Log("Range damage dealt: " + damage);
        }
    }
}