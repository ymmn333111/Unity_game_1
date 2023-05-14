using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score_board : MonoBehaviour
{
    public TMP_Text score_text;
    public float score = 0;
    private bool vs_result;
    string view_high_score = "Score ";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(score);
        score_text.text = view_high_score + score.ToString();
    }

}
