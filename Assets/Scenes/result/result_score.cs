using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class result_score : MonoBehaviour
{
    public float score;
    public TMP_Text scoreText;
    private string show_score;
    // Start is called before the first frame update
    void Start()
    {
        show_score = "Score ";
        scoreText.text = show_score + score.ToString();
    }

    
}
