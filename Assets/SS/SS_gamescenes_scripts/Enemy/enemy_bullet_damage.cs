using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// “G‚Ì’e‚Ìƒ_ƒ[ƒW‚ğ’²®‚·‚éˆ—
public class enemy_bullet_damage : MonoBehaviour
{
    // ƒ_ƒ[ƒW—Ê
    public int damage = 10;
    // ’e‚ªËo‚³‚ê‚Ä‚©‚çÁ‚¦‚é‚Ü‚Å‚ÌŠÔ
    public float destroy_time = 5f;
    void Update()
    {
        Destroy(this.gameObject, destroy_time);
    }
    // “G‚Ì’e‚Æ‚ÌÚGˆ—
    private void OnTriggerEnter2D(Collider2D other)
    {
        // player‚É’e‚ªÚG‚µ‚½ê‡‚Ìˆ—
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
