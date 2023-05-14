using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAMIYANOMAR_Stage2_Boss_Move : MonoBehaviour
{
    private int BossHp = 0;
    private enemy_status Enemy_status;
    public GameObject Enemy_Image;
    private bool Image_activate = true;
    private int Boss_Max_hp;
    private float move_speed = 3f;
    private float move_timer = 0f;
    private float move_timer_y = 0f;
    private float way = 0;
    private float way_y = 0;

    private float minimum_x = -7f;
    private float max_x = 7f;
    private float minimum_y = -1f;
    private float max_y = 3.5f;

    private float right = 0f;
    private float left = 2f;
    private float threshold = 1f;
    void Start()
    {
        Enemy_status = this.gameObject.GetComponent<enemy_status>();
        Boss_Max_hp = Enemy_status.hp;
    }

    // Update is called once per frame
    void Update()
    {
        BossHp = Enemy_status.hp;
        if(BossHp <= 0)
        {
            Image_activate = !Image_activate;
            Enemy_Image.SetActive(Image_activate);
            move_speed -= 10 * Time.deltaTime / 5;
            if (move_speed <= 0)
            {
                move_speed = 0;
            }
        }
        if (BossHp < Boss_Max_hp * 0.5)
        {
            BossMove2();
            if (BossHp <= Boss_Max_hp * 0.2)
            {
                move_speed += 0.5f * Time.deltaTime;
            }
        }

        move_timer += Time.deltaTime;
        move_timer_y += Time.deltaTime;

        if (move_timer >= 1f)
        {
            way = define_way();
            move_timer = 0f;
        }
        if(move_timer_y >= 0.8f )
        {
            way_y = define_way_y();
            move_timer_y = 0f;
        }

        BossMove1();
        
    }

    private float define_way()
    {
        float way = Random.Range(right, left);

        if (this.transform.position.x == minimum_x)
        {
            way = 2f;
        }
        else if (this.transform.position.x == max_x)
        {
            way = 0f;
        }

        return way;
    }

    private float define_way_y()
    {
        float way = Random.Range(right, left);
        if (this.transform.position.y == minimum_y)
        {
            way = 2f;
        }
        else if (this.transform.position.y == max_y)
        {
            way = 0f;
        }

        return way;
    }
    private void BossMove1()
    {
        if (way < threshold)
        {
            this.transform.position = new Vector2(Mathf.Clamp(this.transform.position.x - Time.deltaTime * move_speed,minimum_x,max_x), this.transform.position.y);
        }
        else
        {
            this.transform.position = new Vector2(Mathf.Clamp(this.transform.position.x + Time.deltaTime * move_speed, minimum_x, max_x), this.transform.position.y);
        }
    }

    private void BossMove2()
    {
        if (way_y < threshold)
        {
            this.transform.position = new Vector2(this.transform.position.x, Mathf.Clamp(this.transform.position.y - Time.deltaTime * move_speed,minimum_y,max_y));
        }
        else
        {
            this.transform.position = new Vector2(this.transform.position.x, Mathf.Clamp(this.transform.position.y + Time.deltaTime * move_speed, minimum_y, max_y));
        }
    }

}
