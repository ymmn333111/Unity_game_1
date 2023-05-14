using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_key : MonoBehaviour
{
    public float speed = 1;
    float x_Speed = 0;
    float y_Speed = 0;


    private float border_Left;
    private float border_Right;
    private float border_Uppor;
    private float border_Lower;

    private void Start()
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

        x_Speed = 0;
        y_Speed = 0;
        float next_Position_x = 0;
        float next_Position_y = 0;
        Transform player_Transform = this.transform;
        Vector2 pos = player_Transform.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x_Speed = -speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            x_Speed = speed;
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            y_Speed = speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            y_Speed = -speed;
        }
        next_Position_x = pos.x + x_Speed * Time.deltaTime;
        next_Position_y = pos.y + y_Speed * Time.deltaTime;

        transform.position = new Vector2(

             Mathf.Clamp(next_Position_x, border_Left, border_Right),
             Mathf.Clamp(next_Position_y, border_Lower, border_Uppor)
             );
    }
}
