using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace demo2d
{
    public class PlayerShooting : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public float shootingInterval;
        private float lastBulletTime;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                if (Time.time - lastBulletTime > shootingInterval)
                {
                    ShootBullet();
                    lastBulletTime = Time.time;
                }

            }
        }
        private void ShootBullet()
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}

