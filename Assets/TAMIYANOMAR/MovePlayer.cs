using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class MovePlayer : MonoBehaviour
    {
        public GameObject cursor_obj;
        private Vector2 destination;



        void Update()
        {
            destination = new Vector2(cursor_obj.transform.position.x, cursor_obj.transform.position.y);
            Vector2 position_gap = new Vector2(destination.x - this.transform.position.x, destination.y - this.transform.position.y);
            this.transform.position = new Vector2(this.transform.position.x + position_gap.x / 0.1f * Time.deltaTime, this.transform.position.y + position_gap.y / 0.1f * Time.deltaTime);


        }
    }
}
