using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// enemy_bom���K���Ȏ��Ԍ�Ɋg�U����U�����o��悤�ɂ��鏈��
public class enemy_bom_action : MonoBehaviour
{
    // enemy��bom�̎��
    public GameObject bom;
    // bom����g�U�����U���̎��
    public GameObject bom_power;
    // bom����������Ă���g�U�����܂ł̎��Ԃ̐ݒ�
    public float min_time = 2f;
    public float max_time = 8f;
    // bom����������Ă���g�U����鎞��
    private float action_time;
    // �g�U�����U���̊p�x
    public float angle;
    // �g�U�����U���̐�
    public int power_num = 8;
    // �g�U�����U���̑��x
    public float power_speed = 10f;
    private float time;
    void Start()
    {
        time = 0f;
        //bom����������Ă���g�U�����܂ł̎��Ԃ̌���
        action_time = Random.Range(min_time, max_time);
    }

    // �g�U�U���̊p�x����
    public static Vector2 AngleToVector2(float angle)
    {
        var radian = angle * (Mathf.PI / 180);
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)).normalized;
    }
    void Update()
    {
        if (time > action_time)
        {
            // bom����������Ă���g�U����U���̏���
            for (int i = 0; i < power_num; i++)
            {
                GameObject new_bullet = Instantiate(bom_power, bom.transform.position, transform.rotation);
                var a = AngleToVector2(360 / power_num * i);
                var angles = new_bullet.transform.localEulerAngles;
                angles.z = angle;
                new_bullet.transform.localEulerAngles = angles;
                new_bullet.GetComponent<Rigidbody2D>().velocity = a * power_speed;
                if (i == power_num - 1)
                {
                    Destroy(bom);
                }
            }
        }
        time += Time.deltaTime;
        
    }
}
