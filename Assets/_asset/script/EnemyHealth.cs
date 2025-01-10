using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace demo2d
{
    public class EnemyHealth : Health
    {
        public static int LivingEnemyCount;
        public Slider slider;

        private void Awake() => LivingEnemyCount++;

        void Start()
        {
            slider.maxValue = defaultHealthPoint;
        }
        protected override void Die()
        {
            LivingEnemyCount--;
            base.Die();
        }

    }

}
