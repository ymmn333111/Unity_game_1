using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ^‰º‚É—‚¿‚é’e‚Æplayer‚ÉŒü‚©‚Á‚Ä‚­‚é’e‚Ìİ’è‚ğ‚·‚éƒXƒNƒŠƒvƒg
public class enemy_bullet : MonoBehaviour
{
    // ’e‚Ìí—Ş
    public GameObject bullet;
    // ’e‚ªËo‚³‚ê‚éêŠ‚ğw’è
    public GameObject muzzle;
    // “G‚Ìí—Ş
    public GameObject Enemy;
    enemy_status enemy_hp;
    // ’e‚Ì‘¬“x
    private float bullet_speed = 10f;
    private float time = 0f;
    // ’e‚ÌËo‚³‚ê‚éŠÔŠu
    public float bullet_timer = 0.5f;

    void Start()
    {
        enemy_hp = Enemy.GetComponent<enemy_status>();
    }


    void Update()
    {
        if (enemy_hp.hp <= 0)
        {
            this.enabled = false;
        }
        time += Time.deltaTime;

        if (time >= bullet_timer)
        {
            time = 0f;
            GameObject new_bullet;
            // player‚ğ’ÇÕ‚·‚é’e‚ğ¶¬
            if (bullet.name == "look_at_player_bullet")
            {
                float rand = Random.Range(-2, 2);
                Vector2 insta_position = new Vector2(muzzle.transform.position.x + rand, muzzle.transform.position.y + rand);
                new_bullet = Instantiate(bullet, muzzle.transform.position, transform.rotation);
            }
            // ^‰º‚É—‰º‚·‚é’e
            else
            {
                new_bullet = Instantiate(bullet, muzzle.transform.position, transform.rotation);
                new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * -1f);
            }
            
        }
        
    }

}
