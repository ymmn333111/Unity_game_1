using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class GB_scroll : MonoBehaviour
    {
        float Max_position = 12;
        float Minimun_position = -12;
        float ScrollSpeed = 10f;
        // Update is called once per frame
        void Update()
        {
            if (this.gameObject.transform.position.y <= Minimun_position)
            {
                this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, Max_position);
            }
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - ScrollSpeed * Time.deltaTime);
        }
    }
}
