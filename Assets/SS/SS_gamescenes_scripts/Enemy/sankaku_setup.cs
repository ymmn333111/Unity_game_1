using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sankaku_setup : MonoBehaviour
{
    public GameObject Enemy;
    enemy_status enemy_hp;
    enemy_bullet4 enemy_b;
    enemy_bullet5 enemy_b2;
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
        if (enemy_hp.hp <= max_hp / 2)
        {
            enemy_b.enabled = true;
            enemy_b2.enabled = true;
        }
    }
}
