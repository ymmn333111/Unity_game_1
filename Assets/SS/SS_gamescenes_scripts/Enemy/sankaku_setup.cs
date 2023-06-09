using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 三角の弾を射出するための準備をするスクリプト
public class sankaku_setup : MonoBehaviour
{
    // 敵の種類
    public GameObject Enemy;
    // 敵の現在のHP
    enemy_status enemy_hp;
    // 敵の弾の情報
    enemy_bullet4 enemy_b;
    enemy_bullet5 enemy_b2;
    // 敵のHPの最大量
    private int max_hp;

    void Start()
    {
        enemy_hp = Enemy.GetComponent<enemy_status>();
        enemy_b = Enemy.GetComponent<enemy_bullet4>();
        enemy_b2 = Enemy.GetComponent<enemy_bullet5>();
        max_hp = enemy_hp.hp;
    }


    void Update()
    {
        // 敵のHPが最大量の半分になった際に三角の弾が放出されるようにする処理
        if (enemy_hp.hp <= max_hp / 2)
        {
            enemy_b.enabled = true;
            enemy_b2.enabled = true;
        }
    }
}
