using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace demo2d
{
    public class PlayerHealth : Health
    {
        protected override void Die()
        {
            base.Die();
            Debug.Log("Player died");
        }
    }
}
