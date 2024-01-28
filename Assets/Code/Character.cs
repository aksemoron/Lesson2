using System;
using UnityEngine;

namespace Code
{
    public sealed class Character : MonoBehaviour
    {
        public WeekDays Type;
        public bool IsDead;
        private int _hp;

        public void Damage(int i)
        {
            _hp -= i;
            if (_hp <= 0)
            {
                IsDead = true;
            }
        }

        private void Start()
        {
            GetComponent<ExampleCycle>();
        }
    }
}
