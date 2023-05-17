using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// OŠp‚Ì’e‚ğËo‚·‚é‚½‚ß‚Ì€”õ‚ğ‚·‚éƒXƒNƒŠƒvƒg
public class sankaku_setup : MonoBehaviour
{
    // “G‚Ìí—Ş
    public GameObject Enemy;
    // “G‚ÌŒ»İ‚ÌHP
    enemy_status enemy_hp;
    // “G‚Ì’e‚Ìî•ñ
    enemy_bullet4 enemy_b;
    enemy_bullet5 enemy_b2;
    // “G‚ÌHP‚ÌÅ‘å—Ê
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
        // “G‚ÌHP‚ªÅ‘å—Ê‚Ì”¼•ª‚É‚È‚Á‚½Û‚ÉOŠp‚Ì’e‚ª•úo‚³‚ê‚é‚æ‚¤‚É‚·‚éˆ—
        if (enemy_hp.hp <= max_hp / 2)
        {
            enemy_b.enabled = true;
            enemy_b2.enabled = true;
        }
    }
}
