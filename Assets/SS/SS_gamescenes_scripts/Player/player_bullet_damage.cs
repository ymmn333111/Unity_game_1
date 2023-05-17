using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// playerの通常攻撃のダメージ処理
public class player_bullet_damage : MonoBehaviour
{
    private GameObject Player;

    // playerのhp処理のためのスクリプト
    player_status script;
    private void Start()
    {
        Player = GameObject.Find("Player"); 
        script = Player.GetComponent<player_status>();
    }

    // playerの通常攻撃のダメージ量
    public int damage = 1;

    void Update()
    {
        Destroy(this.gameObject, 5.0f);
    }

    // playerの通常攻撃が敵に被弾した際のダメージ処理
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            
            var damagetarget = other.gameObject.GetComponent<EDmage>();

            if (damagetarget != null)
            {
                // ダメージの処理
                other.gameObject.GetComponent<EDmage>().AddDamage(damage);
                other.gameObject.GetComponent<EDmage>().AddScore(damage);
                if (script.hp == script.max_hp)
                {
                }
                else {
                    script.hp += damage;
                }

                Destroy(this.gameObject);

            }
        }
    }
}
