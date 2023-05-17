using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// playerのビーム処理
public class player_beem_damage : MonoBehaviour
{
    // ビームのダメージ
    public int damage = 1000;
    void Update()
    {
        Destroy(this.gameObject, 5.0f);
    }

    // ビームがenemyに直撃した際のダメージ処理
    private void OnTriggerExit2D(Collider2D other)
    {
        // enemyのみに処理を実行
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log($"GG");

            var damagetarget = other.gameObject.GetComponent<EDmage>();

            // enemyに対するダメージ計算とスコア加算
            if (damagetarget != null)
            {
                other.gameObject.GetComponent<EDmage>().AddDamage(damage);
                other.gameObject.GetComponent<EDmage>().AddScore(damage);

            }
        }
    }
}
