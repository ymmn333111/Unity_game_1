using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// playerの移動に関するスクリプト
public class Move_key : MonoBehaviour
{
    // playerの速度
    public float speed = 1;

    // playerの各軸の速度
    float x_Speed = 0;
    float y_Speed = 0;

    // playerの移動上限
    private float border_Left;
    private float border_Right;
    private float border_Uppor;
    private float border_Lower;

    private void Start()
    {
        // player機体が画面外に出ないようにする設定
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
        // 移動する速度
        x_Speed = 0;
        y_Speed = 0;

        // 次の移動先
        float next_Position_x = 0;
        float next_Position_y = 0;
        
        // playerの現在位置
        Transform player_Transform = this.transform;
        Vector2 pos = player_Transform.position;

        // 横移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x_Speed = -speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            x_Speed = speed;
        }

        // 縦移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            y_Speed = speed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            y_Speed = -speed;
        }

        // 移動計算
        next_Position_x = pos.x + x_Speed * Time.deltaTime;
        next_Position_y = pos.y + y_Speed * Time.deltaTime;

        // 画面外判定
        transform.position = new Vector2(

             Mathf.Clamp(next_Position_x, border_Left, border_Right),
             Mathf.Clamp(next_Position_y, border_Lower, border_Uppor)
             );
    }
}
