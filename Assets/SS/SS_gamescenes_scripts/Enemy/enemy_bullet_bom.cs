using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ˆê’èŠÔŒã‚ÉŠgU‚·‚é¯Œ`‚ÌUŒ‚‚ğ‚·‚éƒXƒNƒŠƒvƒg
public class enemy_bullet_bom : MonoBehaviour
{
    // “G‚Ìí—Ş
    public GameObject Enemy;
    // “G‚Ì’e‚ªËo‚³‚ê‚éêŠ
    public GameObject muzzle;
    // ’e‚Ì‘¬“x
    public float bullet_speed = 10f;
    enemy_status enemy_hp;
    private float time = 0f;
    // ’e‚ÌŠÔŠu
    public float bullet_timer = 0.5f;
    // “G‚Ì’e‚Ìí—Ş
    public GameObject bom;
    // “G‚ÌHP‚ÌÅ‘å—Ê
    private int max_hp;
    void Start()
    {
        enemy_hp = Enemy.GetComponent<enemy_status>();
        max_hp = enemy_hp.hp;
    }

    void Update()
    {
        if (enemy_hp.hp <= 0)
        {
            this.enabled = false;
        }

        // “G‚ÌHP‚ªÅ‘å—Ê‚Ì”¼•ª‚É‚È‚Á‚½‚Æ‚«‚É’e‚ÌŠÔŠu‚ğ‘‚ß‚éˆ—
        if (enemy_hp.hp <= max_hp/2)
        {
            bullet_timer = 0.4f;
        }
        time += Time.deltaTime;

        if (time >= bullet_timer)
        {
            time = 0f;
            GameObject new_bom = Instantiate(bom, muzzle.transform.position, transform.rotation);
            new_bom.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * -1f);

        }

    }
}
