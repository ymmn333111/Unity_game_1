using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 一定時間後に拡散する星形の攻撃をするスクリプト
public class enemy_bullet_bom : MonoBehaviour
{
    // 敵の種類
    public GameObject Enemy;
    // 敵の弾が射出される場所
    public GameObject muzzle;
    // 弾の速度
    public float bullet_speed = 10f;
    enemy_status enemy_hp;
    private float time = 0f;
    // 弾の間隔
    public float bullet_timer = 0.5f;
    // 敵の弾の種類
    public GameObject bom;
    // 敵のHPの最大量
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

        // 敵のHPが最大量の半分になったときに弾の間隔を早める処理
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
