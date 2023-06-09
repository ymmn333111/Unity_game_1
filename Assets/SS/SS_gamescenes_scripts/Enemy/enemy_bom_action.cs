using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// enemy_bomが適当な時間後に拡散する攻撃が出るようにする処理
public class enemy_bom_action : MonoBehaviour
{
    // enemyのbomの種類
    public GameObject bom;
    // bomから拡散される攻撃の種類
    public GameObject bom_power;
    // bomが投下されてから拡散されるまでの時間の設定
    public float min_time = 2f;
    public float max_time = 8f;
    // bomが投下されてから拡散される時間
    private float action_time;
    // 拡散される攻撃の角度
    public float angle;
    // 拡散される攻撃の数
    public int power_num = 8;
    // 拡散される攻撃の速度
    public float power_speed = 10f;
    private float time;
    void Start()
    {
        time = 0f;
        //bomが投下されてから拡散されるまでの時間の決定
        action_time = Random.Range(min_time, max_time);
    }

    // 拡散攻撃の角度処理
    public static Vector2 AngleToVector2(float angle)
    {
        var radian = angle * (Mathf.PI / 180);
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)).normalized;
    }
    void Update()
    {
        if (time > action_time)
        {
            // bomが投下されてから拡散する攻撃の処理
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
