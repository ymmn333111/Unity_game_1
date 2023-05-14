using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stage_right : MonoBehaviour
{
    // Start is called before the first frame update
    private int tmp = 0;
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
        print("right");
        change();
        Debug.Log(tmp);
    }
    public void change()
    {

        audioSource.PlayOneShot(sound1);
        tmp = script.use_stage;
        if(tmp < script.max_stage_number)
        {
            script.use_stage += 1;
        }

    }
}
