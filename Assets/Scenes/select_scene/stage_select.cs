using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stage_select : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI now_stage;
    public GameObject Stage;
    stage_data script;
    // Start is called before the first frame update
    void Start()
    {
        now_stage = GetComponent<TextMeshProUGUI>();
        script = Stage.GetComponent<stage_data>();
    }

    void Update()
    {
        int stage_count = 0;
        string show_text;

        stage_count = script.use_stage;

        show_text = string.Format("{0}", stage_count);
        //Debug.Log(wp_count);
        //null‚ª‘ã“ü‚³‚ê‚Ä‚é‚©‚çŽ¡‚·
        
        if(stage_count == 0)
        {
            show_text = "Tutorial";
        }

        now_stage.text = show_text;

    }
}
