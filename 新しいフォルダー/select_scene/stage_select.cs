using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stage_select : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI now_stage;

    void Start()
    {
        now_stage = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        int wp_count = 0;
        string show_text;

        wp_count = stage_dummy.play_stage;

        show_text = string.Format("{0}", wp_count);
        //Debug.Log(wp_count);
        //null‚ª‘ã“ü‚³‚ê‚Ä‚é‚©‚çŽ¡‚·
        
        if(wp_count == 0)
        {
            show_text = "Tutorial";
        }

        now_stage.text = show_text;

    }
}
