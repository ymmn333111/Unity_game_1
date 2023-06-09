using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 複数の弾を扇状に放出する敵の攻撃のスクリプト
public class enemy_bullet2 : MonoBehaviour
{
    // 敵の種類
    public GameObject Enemy;
    // 弾の種類
    public GameObject bullet3;
    // 弾が出る場所
    public GameObject muzzle;
    // 弾の速度
    public float bullet_speed = 10f;
    enemy_status enemy_hp;
    private float time = 0f;
    // 弾の間隔
    public float bullet_timer = 0.5f;

    // 弾の角度を変更する変数
    private float angle;
    public float angle_change = -90f;
    // 最小角度
    public float min_angle = -70f;
    // 最大角度
    public float max_angle = 70f;
    // 同時に射出される弾の量
    public int count = 3;

    // 角度を変更する処理
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
            // 弾の放出角度を変更しながらcountの数分攻撃する処理
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
