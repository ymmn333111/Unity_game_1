using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy_bullet_stop : MonoBehaviour
{
    private float time_manage = 0f;
    public float time_stop;
    public float min_time = 0.1f;
    public float max_time = 1f;

    void Start()
    {
        time_stop = Random.Range(min_time, max_time);
    }


    void Update()
    {
        if (time_manage >= time_stop)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Destroy(this.gameObject, 5);
        }
        time_manage += Time.deltaTime;
    }
}
