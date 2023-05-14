using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stage_select_boss1 : MonoBehaviour
{
    public Sprite enemy_1;
    public Sprite enemy_2;
    public Sprite enemy_3;
    public GameObject stage_obj;
    public GameObject img_obj;
   // private GameObject self_obj;
    private Image sr;
    stage_data stage_number;
    // Start is called before the first frame update
    void Start()
    {
        stage_number = stage_obj.GetComponent<stage_data>();
        //self_obj = this.gameObject;

        sr = img_obj.GetComponent<Image>();
        sr.sprite = enemy_1;


    }

    // Update is called once per frame
    void Update()
    {
        int now_stage;

        now_stage = stage_number.use_stage;
        switch (now_stage)
        {
            case 1:
                sr.sprite = enemy_1;
                break;

            case 2:
                sr.sprite = enemy_2;
                break;

            case 3:
                sr.sprite = enemy_3;
                break;

            default:
                break;

        }
        
    }
}
