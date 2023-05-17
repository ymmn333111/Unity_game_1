using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// player�̒ʏ�U���̐ݒ�
public class player_shoot : MonoBehaviour
{
    // player�̒ʏ�U���̎��
    public GameObject player_bullet;
    // player�̃r�[���̎��
    public GameObject player_beem;
    // �ʏ�U���̑��x
    public float bullet_speed = 3f;
    // �r�[���̑��x
    public float beem_speed = 3f;
    // �ʏ�U���̔��ˊp�x
    public float angle = 0f;

    private GameObject Player;
    // player��hp����
    player_status script;
    // �ʏ�U���̒e�Ԋu
    public float bullet_sense = 0f;
    // �e�Ԋu�ɕK�v�Ȏ���
    private float time = 0;

    // ����
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

    //�ʏ�U���̊p�x�v�Z
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

        // player�̃r�[������
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
        // player�̒ʏ�U������
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
