using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bom_action : MonoBehaviour
{
    public GameObject bom;
    public GameObject bom_power;
    public float min_time = 2f;
    public float max_time = 8f;
    private float action_time;
    public float angle;
    public int power_num = 8;
    public float power_speed = 10f;
    private float time;
    void Start()
    {
        time = 0f;
        action_time = Random.Range(min_time, max_time);
    }
    public static Vector2 AngleToVector2(float angle)
    {
        var radian = angle * (Mathf.PI / 180);
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)).normalized;
    }
    void Update()
    {
        if (time > action_time)
        {
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
