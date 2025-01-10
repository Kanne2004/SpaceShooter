using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace demo2d
{
    public class PlayerHealth : Health
    {
        public Slider slider;
        void Start()
        {
            slider.maxValue = defaultHealthPoint;
        }
        private void Update()
        {
            slider.value = healthPoint;
        }
        protected override void Die()
        {
            base.Die();
            slider.value = healthPoint;
            Debug.Log("Player died");
        }
        
    }
}
