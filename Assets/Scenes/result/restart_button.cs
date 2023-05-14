using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart_button : MonoBehaviour
{
    // Start is called before the first frame update
    private string prev_scene_name;
    public AudioClip sound1;
    AudioSource audioSource;
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
        prev_scene_name = game_information.Get_Prev_SceneName();
        if (prev_scene_name == null)
        {
            prev_scene_name = "title_scene";
        }
    }
    public void OnClick()
    {
        audioSource.PlayOneShot(sound1);
        SceneManager.LoadScene(prev_scene_name);
    }
}
