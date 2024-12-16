using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace demo2d
{
    public class Bullet : MonoBehaviour
    {
        public float flySpeed;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            var newPosition = transform.position;
            newPosition.y += Time.deltaTime * flySpeed;
            transform.position = newPosition;

        }
    }
}
