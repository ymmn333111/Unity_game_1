using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start_button : MonoBehaviour
{
    // Start is called before the first frame update
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
        audioSource.PlayOneShot(sound1);
        int tmp = 0;
        string stage = "stage_";

        tmp = script.use_stage;

        if(tmp == 0)
        {
            stage = "tutorial";
        }
        else
        {
            stage += string.Format("{0}", script.use_stage);
        }

        SceneManager.LoadScene(stage);
      
    }
}
