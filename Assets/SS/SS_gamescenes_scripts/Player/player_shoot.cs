using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shoot : MonoBehaviour
{
    public GameObject player_bullet;
    public GameObject player_beem;
    public float bullet_speed = 3f;
    public float beem_speed = 3f;
    public float angle = 0f;
    private GameObject Player;
    player_status script;
    public float bullet_sense = 0f;
    private float time = 0;
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

        if (Input.GetKey(KeyCode.P))
        {
            Debug.Log($"{transform.rotation}");
            Debug.Log($"{transform.rotation}");
            GameObject new_bullet = Instantiate(player_bullet, Player.transform.position, transform.rotation);
            var a = AngleToVector2(angle);
            var angles = new_bullet.transform.localEulerAngles;
            angles.z = angle - 90f;
            new_bullet.transform.localEulerAngles = angles;
            new_bullet.GetComponent<Rigidbody2D>().velocity = a * bullet_speed;
        }
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
