using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bullet_damage : MonoBehaviour
{
    private GameObject Player;

    player_status script;
    private void Start()
    {
        Player = GameObject.Find("Player"); 
        script = Player.GetComponent<player_status>();
    }

    public int damage = 1;
    void Update()
    {

        Destroy(this.gameObject, 5.0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {


            var damagetarget = other.gameObject.GetComponent<EDmage>();


            if (damagetarget != null)
            {
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
