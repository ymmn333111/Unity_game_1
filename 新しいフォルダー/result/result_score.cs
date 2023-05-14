using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class result_score : MonoBehaviour
{
    public float score;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    
}
