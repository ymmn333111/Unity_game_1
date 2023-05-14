using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_information : MonoBehaviour
{
    // Start is called before the first frame update
    private static string now_scene_name;
    void Start()
    {
        now_scene_name = SceneManager.GetActiveScene().name;
        //Debug.Log(now_scene_name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static string Get_Prev_SceneName()
    {
        return now_scene_name;
    }
}
