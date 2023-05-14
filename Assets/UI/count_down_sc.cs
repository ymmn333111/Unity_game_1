using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class count_down_sc : MonoBehaviour
{
    public TextMeshProUGUI count_down;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tmp = timer_control.Get_Timer();
        string show_text;

        tmp *= -1;
        if(tmp > 1)
        {
            show_text = string.Format("{0}", (int)tmp);
            count_down.text = show_text;
        }
        else
        {
            show_text = "GO!";
            count_down.text = show_text;
        }

    }
}
