using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class weapon_selet : MonoBehaviour
{

    public TextMeshProUGUI now_weapon;
    public GameObject Weapon;
    weapon_data script;
    // Start is called before the first frame update
    void Start()
    {
        script = Weapon.GetComponent<weapon_data>();
        now_weapon = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        int wp_count = 0;
        string show_text;

        wp_count = script.use_weapon;
        if(wp_count < script.min_weapon_number)
        {
            wp_count = script.min_weapon_number;
        }
        if (wp_count > script.max_weapon_number)
        {
            wp_count = script.max_weapon_number;
        }

        //ëIëíÜÇÃweaponî‘çÜÇï\é¶
        show_text = string.Format("{0}", wp_count);
 

        now_weapon.text = show_text;

    }
}
