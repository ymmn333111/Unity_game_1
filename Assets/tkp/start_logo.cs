using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_logo : MonoBehaviour
{
    public Sprite img_1;
    public Sprite img_2;
    public GameObject button;
    private Image sr;
    private float timer;
    void Start()
    {
        sr = button.GetComponent<Image>();
        timer = 0;
        sr.sprite = img_2;
        
    }

    void Update()
    {
        if(((timer) % 2) >= 1)
        {
            sr.sprite = img_2;
        }
        else
        {
            
            sr.sprite = img_1;
        }
        if (timer > 10)
        {
            timer = 0;
        }
        timer += Time.deltaTime;
        //Debug.Log(timer);

    }

}
