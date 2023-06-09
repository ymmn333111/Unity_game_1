using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 三角の弾が射出された後一定時間フィールドにとどまるように設定するスクリプト
public class enemy_bullet_stop : MonoBehaviour
{
    // 弾が止まるまでの経過時間を計測
    private float time_manage = 0f;
    // 停止する時間を格納する変数
    public float time_stop;
    // 停止する時間の幅
    public float min_time = 0.1f;
    public float max_time = 1f;

    void Start()
    {
        time_stop = Random.Range(min_time, max_time);
    }


    void Update()
    {
        // 弾が停止する処理
        if (time_manage >= time_stop)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Destroy(this.gameObject, 5);
        }
        time_manage += Time.deltaTime;
    }
}
