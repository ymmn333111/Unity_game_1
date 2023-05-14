using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class weapon_selet : MonoBehaviour
{

    public TextMeshProUGUI now_weapon;

    void Start()
    {
        now_weapon = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        int wp_count = 0;
        string show_text;

        wp_count = weapon_dummy.use_weapon;
        if(wp_count < 0)
        {
            wp_count = 0;
        }

        show_text = string.Format("{0}", wp_count);
 

        now_weapon.text = show_text;

    }
}
