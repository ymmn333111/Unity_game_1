using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class TAMIYANOMAR_enemy_move : MonoBehaviour
    {
        private float move_speed = 3f;
        private float move_timer = 0f;
        private float way = 0;

        private float minimum_x = -20f;
        private float max_x = 20f;

        private float right = 0f;
        private float left = 2f;
        private float threshold = 1f;

        void Update()
        {
            move_timer += Time.deltaTime;

            if (move_timer >= 1f)
            {
                way = define_way();
                move_timer = 0f;
            }
            move(way);
        }

        private void move(float way)
        {
            if (way < threshold)
            {
                this.transform.position = new Vector2(this.transform.position.x - Time.deltaTime * move_speed, this.transform.position.y);
            }
            else
            {
                this.transform.position = new Vector2(this.transform.position.x + Time.deltaTime * move_speed, this.transform.position.y);
            }
        }

        private float define_way()
        {
            float way = Random.Range(right, left);

            if (this.transform.position.x < minimum_x)
            {
                way = 2f;
            }
            else if (this.transform.position.x > max_x)
            {
                way = 0f;
            }

            return way;
        }
    }
}
