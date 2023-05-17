using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// player‚Ì’ÊíUŒ‚‚Ìİ’è
public class player_shoot : MonoBehaviour
{
    // player‚Ì’ÊíUŒ‚‚Ìí—Ş
    public GameObject player_bullet;
    // player‚Ìƒr[ƒ€‚Ìí—Ş
    public GameObject player_beem;
    // ’ÊíUŒ‚‚Ì‘¬“x
    public float bullet_speed = 3f;
    // ƒr[ƒ€‚Ì‘¬“x
    public float beem_speed = 3f;
    // ’ÊíUŒ‚‚Ì”­ËŠp“x
    public float angle = 0f;

    private GameObject Player;
    // player‚Ìhpˆ—
    player_status script;
    // ’ÊíUŒ‚‚Ì’eŠÔŠu
    public float bullet_sense = 0f;
    // ’eŠÔŠu‚É•K—v‚ÈŠÔ
    private float time = 0;

    // ‰¹Œ¹
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

    //’ÊíUŒ‚‚ÌŠp“xŒvZ
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

        // player‚Ìƒr[ƒ€ˆ—
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
        // player‚Ì’ÊíUŒ‚ˆ—
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
