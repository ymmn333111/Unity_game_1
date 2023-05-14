using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start_button : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClisk()
    {
        int tmp = 0;
        string stage = "stage_";

        stage_dummy dummy;

        tmp = stage_dummy.play_stage;

        if(tmp == 0)
        {
            stage = "tutorial";
        }
        else
        {
            stage += string.Format("{0}", 1);
        }

        SceneManager.LoadScene(stage);
      
    }
}
