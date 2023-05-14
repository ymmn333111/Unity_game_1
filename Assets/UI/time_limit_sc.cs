using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class time_limit_sc : MonoBehaviour
{
    public TextMeshProUGUI time_left;
    public float  time_limit = 200;
    public GameObject player_score;
    score_board script;

    // Start is called before the first frame update
    void Start()
    {
        
        string show_text;

         show_text = string.Format("{0}", time_limit);
         time_left.text = show_text;
         
         script = player_score.GetComponent<score_board>();

    }

    // Update is called once per frame
    void Update()
    {
        float tmp = timer_control.Get_Timer();
        string show_text;

        tmp = time_limit - tmp;

        show_text = string.Format("Time limit :{0:f2}", tmp);
        time_left.text = show_text;

        if (tmp <= 0)
        {
            GetComponent<result_value_send>().enabled = true;
        }
    }
}
