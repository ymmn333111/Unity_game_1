using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 敵の弾のダメージを調整する処理
public class enemy_bullet_damage : MonoBehaviour
{
    // ダメージ量
    public int damage = 10;
    // 弾が射出されてから消えるまでの時間
    public float destroy_time = 5f;
    void Update()
    {
        Destroy(this.gameObject, destroy_time);
    }
    // 敵の弾との接触処理
    private void OnTriggerEnter2D(Collider2D other)
    {
        // playerに弾が接触した場合の処理
        if (other.gameObject.CompareTag("Player"))
        {

            var damagetarget = other.gameObject.GetComponent<IDamagable>();


            if (damagetarget != null)
            {
                other.gameObject.GetComponent<IDamagable>().AddDamage(damage);
                other.gameObject.GetComponent<IDamagable>().AddEnergy(damage);
                other.gameObject.GetComponent<IDamagable>().AddScore(damage);
            }
            Destroy(this.gameObject);
        }
    }
}
