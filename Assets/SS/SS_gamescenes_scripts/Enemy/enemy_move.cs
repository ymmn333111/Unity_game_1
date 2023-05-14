using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour
{
    private int BossHp = 0;
    private enemy_status Enemy_status;
    public float move_speed = 10f;
    public float min_range = -5f;
    public float max_range = 5f;
    private int direction = 1;
    private Vector2 pos;


    private void Start()
    {
        Enemy_status = this.gameObject.GetComponent<enemy_status>();
    }


    void Update()
    {
        BossHp = Enemy_status.hp;
        if(BossHp <= 0)
        {
            move_speed -= 10 * Time.deltaTime / 5;
            if(move_speed <= 0)
            {
                move_speed = 0;
            }
        }
        pos = transform.position;
        if (pos.x <= min_range)
        {
            direction = 1;
            transform.Translate(transform.right * move_speed * Time.deltaTime * direction);

        }
        if (pos.x >= max_range)
        {
            direction = -1;
            transform.Translate(transform.right * Time.deltaTime * move_speed * direction);

        }
        transform.Translate(transform.right * move_speed * Time.deltaTime * direction);
    }
}
