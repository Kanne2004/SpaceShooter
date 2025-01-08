using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace demo2d
{
    public class PlayerMove : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            var worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            worldPoint.z = 0;
            transform.position = worldPoint;

        }
    }
}
