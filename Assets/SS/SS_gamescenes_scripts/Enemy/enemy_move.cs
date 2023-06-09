using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 敵の動作に関するスクリプト
public class enemy_move : MonoBehaviour
{
    // 敵のHP
    private int BossHp = 0;
    private enemy_status Enemy_status;
    // 敵の移動速度
    public float move_speed = 10f;
    // 敵の移動する範囲
    public float min_range = -5f;
    public float max_range = 5f;
    // 敵の移動する方向
    private int direction = 1;
    // 敵の現在地
    private Vector2 pos;


    private void Start()
    {
        Enemy_status = this.gameObject.GetComponent<enemy_status>();
    }


    void Update()
    {
        BossHp = Enemy_status.hp;
        // 敵のHPが０になった時に徐々にスピードが落ちて停止する処理
        if(BossHp <= 0)
        {
            move_speed -= 10 * Time.deltaTime / 5;
            if(move_speed <= 0)
            {
                move_speed = 0;
            }
        }
        pos = transform.position;

        // 移動範囲を超えたときに移動方向を変える処理
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
