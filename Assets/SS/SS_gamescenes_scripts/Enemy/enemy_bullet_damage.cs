using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet_damage : MonoBehaviour
{

    public int damage = 10;
    public float destroy_time = 5f;
    void Update()
    {
        Destroy(this.gameObject, destroy_time);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

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
