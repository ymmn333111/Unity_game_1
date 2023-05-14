using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    float game_time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        game_time += Time.deltaTime;
        if(game_time >= 10)
        {
            Debug.Log("game over");
        }
    }
}
