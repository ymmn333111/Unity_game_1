using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class left_ar : MonoBehaviour
{
    // Start is called before the first frame update
    private int tmp = 0;
    public void OnClisk()
    {
        print("left");
        change();
        Debug.Log(tmp);
    }
    public void change()
    {
        //int tmp = 0;

 
        tmp = stage_dummy.play_stage;
        if(tmp >= 0)
        {
            stage_dummy.play_stage -= 1;
        }

        
    }
}
