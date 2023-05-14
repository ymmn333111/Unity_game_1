using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class press_start_img : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject press_start_image;
    private float timer;
    private bool flag;
    void Start()
    {
        timer = 0;
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        float now;

        now = Time.deltaTime;
        timer += now;

        if(((int)timer) % 2 == 0)
        {
            flag = true;
        }
        else
        {
            flag = false;
        }
        if(timer > 10)
        {
            timer = 0;
        }
        press_start_image.SetActive(flag);
    }
}
