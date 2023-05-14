using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stage_left : MonoBehaviour
{
    // Start is called before the first frame update
    private int tmp = 1;
    public GameObject Stage;
    stage_data script;
    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        script = Stage.GetComponent<stage_data>();
        audioSource = GetComponent<AudioSource>();
    }
    public void OnClisk()
    {
        print("left");
        change();
        Debug.Log(tmp);
    }
    public void change()
    {
        //int tmp = 0;

        audioSource.PlayOneShot(sound1);
        tmp = script.use_stage;
        if(tmp > script.min_stage_number)
        {
            script.use_stage -= 1;
        }

        
    }
}
