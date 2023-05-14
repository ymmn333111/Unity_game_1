using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class cursor_manip : MonoBehaviour
    {
        private Vector2 mouse_position;
        private Vector2 map_size = new Vector2(20, 8);
        void Start()
        {
            Cursor.visible = false;
        }

        void Update()
        {

            Vector2 mouse_position_gap = new Vector2((Input.mousePosition.x - mouse_position.x) / Screen.width * 40f, (Input.mousePosition.y - mouse_position.y) / Screen.height * 40f);
            if (this.transform.position.x + mouse_position_gap.x > -1 * map_size.x && this.transform.position.x + mouse_position_gap.x < map_size.x && this.transform.position.y + mouse_position_gap.y > -1 * map_size.y && this.transform.position.y + mouse_position_gap.y < map_size.y)
            {
                this.transform.position = new Vector2(this.transform.position.x + mouse_position_gap.x, this.transform.position.y + mouse_position_gap.y);
            }
            mouse_position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }
}
