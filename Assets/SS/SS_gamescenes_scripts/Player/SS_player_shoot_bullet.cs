using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class SS_player_shoot_bullet : MonoBehaviour
    {
    public GameObject player_bullet;
    public GameObject player_beem;
    public float bullet_speed = 3f;
    public float beem_speed = 3f;
    public float angle = 0f;
    public int count = 5;
    private GameObject Player;
    player_status script;
    public float bullet_sense = 0f;
    private float time = 0;
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;
    static private float timer_max = 0.3f;
    private float timer = timer_max;
    public float angle_change = 15f;
    private float ini_angle;


    void Start()
    {
        time = bullet_sense;
        Player = GameObject.Find("Player");
        script = Player.GetComponent<player_status>();
        audioSource = GetComponent<AudioSource>();
        ini_angle = angle;
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
            GetComponent<SS_player_shoot_bullet>().enabled = false;
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
            if (script.energy == script.max_energy)
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
                audioSource.PlayOneShot(sound1);
                time = 0;
                for (int i = 0; i < count; i++)
                {
                    GameObject new_bullet = Instantiate(player_bullet, Player.transform.position, transform.rotation);
                    var a = AngleToVector2(angle);
                    var angles = new_bullet.transform.localEulerAngles;
                    angles.z = angle - 90f;
                    new_bullet.transform.localEulerAngles = angles;
                    new_bullet.GetComponent<Rigidbody2D>().velocity = a * bullet_speed;
                    angle += angle_change;
                }
                angle = ini_angle;
                
            }

        }
        time += Time.deltaTime;
    }
}
