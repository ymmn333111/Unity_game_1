using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_beem_damage : MonoBehaviour
{
    private void Start()
    {
    }

    public int damage = 1000;
    void Update()
    {

        Destroy(this.gameObject, 5.0f);
    }
    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log($"GG");

            var damagetarget = other.gameObject.GetComponent<EDmage>();


            if (damagetarget != null)
            {
                other.gameObject.GetComponent<EDmage>().AddDamage(damage);
                other.gameObject.GetComponent<EDmage>().AddScore(damage);

            }
        }
    }
}
