using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class bullet_rotate : MonoBehaviour
    {
        private float rotate_speed = 300;
        void Update()
        {
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y, this.transform.eulerAngles.z + (rotate_speed * Time.deltaTime));
        }
    }
}
