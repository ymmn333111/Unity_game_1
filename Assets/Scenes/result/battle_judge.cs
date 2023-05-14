using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battle_judge : MonoBehaviour
{
    public GameObject show_win;
    public GameObject show_lose;
    public bool game_result;
    // Start is called before the first frame update
    void Start()
    {
        if (game_result)
        {
            show_win.SetActive(true);
        }
        else
        {
            show_lose.SetActive(true);
        }
    }

}
