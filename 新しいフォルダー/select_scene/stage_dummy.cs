using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage_dummy : MonoBehaviour
{

    public static int play_stage = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("dummy_on");
    }

    // Update is called once per frame
    void Update()
    {
        if(play_stage < 0)
        {
            play_stage = 0;
        }
        else if(play_stage >= 6)
        {
            play_stage = 6;
        }

    }
    public int GetSetProperty
    {
        get { return play_stage; }
        set { play_stage = value; }
    }
}
