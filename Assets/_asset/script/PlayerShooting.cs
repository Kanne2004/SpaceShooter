using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace demo2d
{
    public class PlayerShooting : MonoBehaviour
    {
        public GameObject bulletPrefabs;
        public float shootingInterval;
        public Vector3 bulletOffset;

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
                UpdateFiring();
            }
        }
        private void UpdateFiring()
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }

        private void ShootBullet()
        {
            var bullet = Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);
        }

    }
}

