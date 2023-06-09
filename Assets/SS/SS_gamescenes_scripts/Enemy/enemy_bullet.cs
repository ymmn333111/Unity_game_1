using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 真下に落ちる弾とplayerに向かってくる弾の設定をするスクリプト
public class enemy_bullet : MonoBehaviour
{
    // 弾の種類
    public GameObject bullet;
    // 弾が射出される場所を指定
    public GameObject muzzle;
    // 敵の種類
    public GameObject Enemy;
    enemy_status enemy_hp;
    // 弾の速度
    private float bullet_speed = 10f;
    private float time = 0f;
    // 弾の射出される間隔
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
            // playerを追跡する弾を生成
            if (bullet.name == "look_at_player_bullet")
            {
                float rand = Random.Range(-2, 2);
                Vector2 insta_position = new Vector2(muzzle.transform.position.x + rand, muzzle.transform.position.y + rand);
                new_bullet = Instantiate(bullet, muzzle.transform.position, transform.rotation);
            }
            // 真下に落下する弾
            else
            {
                new_bullet = Instantiate(bullet, muzzle.transform.position, transform.rotation);
                new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * -1f);
            }
            
        }
        
    }

}
