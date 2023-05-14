using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_effect_enemy : MonoBehaviour
{
    private Rigidbody2D ridgidBody;
    private GameObject source;
    public GameObject hit_effect;
    public GameObject muzzle;

    // Start is called before the first frame update
    void Start()
    {
        ridgidBody = GetComponent<Rigidbody2D>();
        source = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player_bullet"))
        {
            Debug.Log("hit");
            Instantiate(hit_effect, source.transform.position,transform.rotation);
        }
    }
}
