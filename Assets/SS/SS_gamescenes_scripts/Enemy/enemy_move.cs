using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// “G‚Ì“®ì‚ÉŠÖ‚·‚éƒXƒNƒŠƒvƒg
public class enemy_move : MonoBehaviour
{
    // “G‚ÌHP
    private int BossHp = 0;
    private enemy_status Enemy_status;
    // “G‚ÌˆÚ“®‘¬“x
    public float move_speed = 10f;
    // “G‚ÌˆÚ“®‚·‚é”ÍˆÍ
    public float min_range = -5f;
    public float max_range = 5f;
    // “G‚ÌˆÚ“®‚·‚é•ûŒü
    private int direction = 1;
    // “G‚ÌŒ»İ’n
    private Vector2 pos;


    private void Start()
    {
        Enemy_status = this.gameObject.GetComponent<enemy_status>();
    }


    void Update()
    {
        BossHp = Enemy_status.hp;
        // “G‚ÌHP‚ª‚O‚É‚È‚Á‚½‚É™X‚ÉƒXƒs[ƒh‚ª—‚¿‚Ä’â~‚·‚éˆ—
        if(BossHp <= 0)
        {
            move_speed -= 10 * Time.deltaTime / 5;
            if(move_speed <= 0)
            {
                move_speed = 0;
            }
        }
        pos = transform.position;

        // ˆÚ“®”ÍˆÍ‚ğ’´‚¦‚½‚Æ‚«‚ÉˆÚ“®•ûŒü‚ğ•Ï‚¦‚éˆ—
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
