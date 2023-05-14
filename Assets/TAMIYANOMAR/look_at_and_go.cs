using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_at_and_go : MonoBehaviour
{
    private float timer = 0f;
    private float look_at_end_time = 1f;
    private GameObject player_obj;
    public string player_name = "Player";
    private float bullet_speed = 50;
    private float angle_gap = 0f;
 
    void Start()
    {
        player_obj = GameObject.Find(player_name);

        float gap_x = player_obj.transform.position.x - this.transform.position.x;
        float gap_y = player_obj.transform.position.y - this.transform.position.y;

        if (gap_x < 0)
        {
            angle_gap = Mathf.Rad2Deg * Mathf.Atan(Mathf.Abs(gap_y)/ Mathf.Abs(gap_x));
        }
        else
        {
            angle_gap = 180 - Mathf.Rad2Deg * Mathf.Atan(-1*gap_y/gap_x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer < look_at_end_time)
        {
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y, this.transform.eulerAngles.z + (angle_gap /look_at_end_time * Time.deltaTime));
        }
        else
        {
            Vector3 velocity = gameObject.transform.rotation * new Vector3(bullet_speed, 0, 0) * -1;
            this.transform.position += velocity * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
    }
}
