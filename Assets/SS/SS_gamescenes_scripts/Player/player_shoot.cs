using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// playerΜΚνUΜέθ
public class player_shoot : MonoBehaviour
{
    // playerΜΚνUΜνή
    public GameObject player_bullet;
    // playerΜr[Μνή
    public GameObject player_beem;
    // ΚνUΜ¬x
    public float bullet_speed = 3f;
    // r[Μ¬x
    public float beem_speed = 3f;
    // ΚνUΜ­Λpx
    public float angle = 0f;

    private GameObject Player;
    // playerΜhp
    player_status script;
    // ΚνUΜeΤu
    public float bullet_sense = 0f;
    // eΤuΙKvΘΤ
    private float time = 0;

    // ΉΉ
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;


    void Start()
    {
        time = bullet_sense;
        Player = GameObject.Find("Player"); 
        script = Player.GetComponent<player_status>();
        audioSource = GetComponent<AudioSource>();
    }

    //ΚνUΜpxvZ
    public static Vector2 AngleToVector2(float angle)
    {
        var radian = angle * (Mathf.PI / 180);
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)).normalized;
    }

    void Update()
    {

        if (script.hp <= 0)
        {
            GetComponent<player_shoot>().enabled = false;
        }

        // playerΜr[
        if (Input.GetKeyDown(KeyCode.X))
        {
            if(script.energy == script.max_energy)
            {

                GameObject new_bullet = Instantiate(player_beem, Player.transform.position, transform.rotation);
                new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, beem_speed);
                script.energy = 0;
                audioSource.PlayOneShot(sound2);
            }
        }
        // playerΜΚνU
        if (Input.GetKey(KeyCode.Z))
        {
            if (time >= bullet_sense)
            {

                GameObject new_bullet = Instantiate(player_bullet, Player.transform.position, transform.rotation);
                new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed);
                time = 0f;
                audioSource.PlayOneShot(sound1);
            }

        }
        time += Time.deltaTime;
    }
}
