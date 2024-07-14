using System;
using Units;
using Units.UnitSystems;
using UnityEngine;
using UnityEngine.Serialization;

namespace DefaultNamespace
{
    public class UnitImplementation : MonoBehaviour
    {
        public GameObject unitModular;
        public GameObject unitUniversal;

        private void Start()
        {
            unitModular.GetComponent<MeleeAttack>().Attack(5);
            unitModular.GetComponent<MoveUnit>().Move(1);
            unitModular.GetComponent<UnitHealth>().GetDamage(2);

            ArcherUnit archerUnit = unitUniversal.GetComponent<ArcherUnit>();
            archerUnit.Attack(5);
            archerUnit.Move(1);
            archerUnit.GetDamage(2);
            
        }
    }
}