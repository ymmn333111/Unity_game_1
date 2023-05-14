using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class right_ar : MonoBehaviour
{
    // Start is called before the first frame update
    private int tmp = 0;
    public void OnClisk()
    {
        print("right");
        change();
        Debug.Log(tmp);
    }
    public void change()
    {
        

        tmp = stage_dummy.play_stage;
        if(tmp < 5)
        {
            stage_dummy.play_stage += 1;
        }

    }
}
