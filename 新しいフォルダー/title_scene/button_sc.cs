using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button_sc : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClisk()
    {

        SceneManager.LoadScene("select_scene");
      
    }
}
