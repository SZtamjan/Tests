using Units.Interfaces;
using UnityEngine;

namespace Units.UnitSystems
{
    public class MoveUnit : MonoBehaviour, IMove
    {
        public void Move(int distance)
        {
            Debug.Log("Unit moved by distance: " + distance);
        }
    }
}