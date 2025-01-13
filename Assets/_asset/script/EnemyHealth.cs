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

        private void Awake()
        {
            LivingEnemyCount++;
            healthPoint = defaultHealthPoint;
            slider.maxValue = defaultHealthPoint;
            slider.value = healthPoint;
        }
        private void Update()
        {
            slider.value = healthPoint;
        }
        protected override void Die()
        {
            LivingEnemyCount--;
            base.Die();
        }

    }

}
