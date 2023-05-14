using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet_reflect : MonoBehaviour
{

    private float border_Left;
    private float border_Right;
    private float border_Uppor;
    private float border_Lower;

    void Start()
    {
        Camera mainCamera = Camera.main;
        Vector3 upper_Right = mainCamera.ViewportToWorldPoint(new Vector3(1.0f, 1.0f, 0));
        Vector3 lower_Left = mainCamera.ViewportToWorldPoint(new Vector3(0.0f, 0.0f, 0));
        border_Left = lower_Left.x;
        border_Right = upper_Right.x;
        border_Uppor = upper_Right.y;
        border_Lower = lower_Left.y;
    }


    void Update()
    {
        if (border_Left >= this.transform.position.x || border_Right <= this.transform.position.x)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x * -1, this.GetComponent<Rigidbody2D>().velocity.y);
        }
        if (border_Lower >= this.transform.position.y || border_Uppor <= this.transform.position.y)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(this.GetComponent<Rigidbody2D>().velocity.x, this.GetComponent<Rigidbody2D>().velocity.y * -1);
        }
    }
}
