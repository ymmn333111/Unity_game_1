using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet : MonoBehaviour
{
    public GameObject bullet;
    public GameObject muzzle;
    public GameObject Enemy;
    enemy_status enemy_hp;
    private float bullet_speed = 10f;
    private float time = 0f;
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
            if (bullet.name == "look_at_player_bullet")
            {
                float rand = Random.Range(-2, 2);
                Vector2 insta_position = new Vector2(muzzle.transform.position.x + rand, muzzle.transform.position.y + rand);
                new_bullet = Instantiate(bullet, muzzle.transform.position, transform.rotation);
            }
            else
            {
                new_bullet = Instantiate(bullet, muzzle.transform.position, transform.rotation);
                new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * -1f);
            }
            
        }
        
    }

}
