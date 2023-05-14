using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class high_score : MonoBehaviour
{
    public float score;
    public TMP_Text scoreText;
    public GameObject input_enemy_num;
    result_enemy_num get_num;
    // Start is called before the first frame update
    void Start()
    {
        float high_score;
        string show_high_score = "high_score_";
        string view_high_score = "High Score ";

        get_num = input_enemy_num.GetComponent<result_enemy_num>();
        show_high_score += get_num.enemy_num.ToString();
        Debug.Log(get_num.enemy_num);


        high_score = PlayerPrefs.GetFloat(show_high_score);
        if(high_score < score)
        {
            PlayerPrefs.SetFloat(show_high_score, score);
            view_high_score += score.ToString();
        }
        else
        {
            view_high_score += high_score.ToString();
        }

        scoreText.text = view_high_score;
        Debug.Log(high_score);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
