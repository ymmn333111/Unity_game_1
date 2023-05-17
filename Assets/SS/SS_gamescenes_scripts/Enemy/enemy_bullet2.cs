using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����̒e����ɕ��o����G�̍U���̃X�N���v�g
public class enemy_bullet2 : MonoBehaviour
{
    // �G�̎��
    public GameObject Enemy;
    // �e�̎��
    public GameObject bullet3;
    // �e���o��ꏊ
    public GameObject muzzle;
    // �e�̑��x
    public float bullet_speed = 10f;
    enemy_status enemy_hp;
    private float time = 0f;
    // �e�̊Ԋu
    public float bullet_timer = 0.5f;

    // �e�̊p�x��ύX����ϐ�
    private float angle;
    public float angle_change = -90f;
    // �ŏ��p�x
    public float min_angle = -70f;
    // �ő�p�x
    public float max_angle = 70f;
    // �����Ɏˏo�����e�̗�
    public int count = 3;

    // �p�x��ύX���鏈��
    public static Vector2 AngleToVector2(float angle)
    {
        var radian = angle * (Mathf.PI / 180);
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)).normalized;
    }
    void Start()
    {
        enemy_hp = Enemy.GetComponent<enemy_status>();
    }

    void Update()
    {
        if (enemy_hp.hp <= 0)
        {
            this.enabled = false;
        }
        time += Time.deltaTime;

        if (time >= bullet_timer)
        {
            time = 0f;
            // �e�̕��o�p�x��ύX���Ȃ���count�̐����U�����鏈��
            for (int i = 0; i < count; i++)
            {
                float angle = Random.Range(min_angle, max_angle);
                GameObject new_bullet = Instantiate(bullet3, muzzle.transform.position, transform.rotation);
                var a = AngleToVector2(angle);
                var angles = new_bullet.transform.localEulerAngles;
                angles.z = angle + angle_change;
                new_bullet.transform.localEulerAngles = angles;
                new_bullet.GetComponent<Rigidbody2D>().velocity = a * bullet_speed;
            }
            
        }

    }
}
