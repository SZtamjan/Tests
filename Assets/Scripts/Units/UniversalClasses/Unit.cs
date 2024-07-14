using Units.Interfaces;
using UnityEngine;

namespace Units.UniversalClasses
{
    public class Unit : MonoBehaviour, IHealth, IAttack, IMove
    {
        public int Health { get; set; }
        
        public virtual void Attack(int damage)
        {
            Debug.Log("Zadano " + damage);
        }

        public virtual void GetDamage(int damage)
        {
            Debug.Log("Dostano " + damage + " damagu");
        }

        public virtual void Move(int distance)
        {
            Debug.Log("Przemieszczono sie o " + distance + " hexow");
        }
    }
}