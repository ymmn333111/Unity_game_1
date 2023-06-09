using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
public class SS_player_shoot_bullet : MonoBehaviour
{
    // playerの通常攻撃の種類
    public GameObject player_bullet;
    // playerのビームの種類
    public GameObject player_beem;
    // 通常攻撃の速度
    public float bullet_speed = 3f;
    // ビームの速度
    public float beem_speed = 3f;
    // 通常攻撃の角度
    public float angle = 0f;
    // 一度の入力で射出する弾の数
    public int count = 5;


    private GameObject Player;
    // playerのhp処理
    player_status script;
    
    // 通常の弾間隔
    public float bullet_sense = 0f;
    // 通常の弾間隔の時間
    private float time = 0;

    // 音源
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;
    
    
    //static private float timer_max = 0.3f;
    //private float timer = timer_max;

    // 通常攻撃の弾角度
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

    // 通常攻撃の角度処理
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

        // ビームの処理
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
        // 通常攻撃の処理
        if (Input.GetKey(KeyCode.Z))
        {
            if (time >= bullet_sense)
            {
                audioSource.PlayOneShot(sound1);
                time = 0;
                // 弾の角度処理
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
