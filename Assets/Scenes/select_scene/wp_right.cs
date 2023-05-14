using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wp_right : MonoBehaviour
{
    private int tmp = 0;
    // Start is called before the first frame update
    public void OnClick()
    {
 
        change();
        Debug.Log(tmp);
    }
    public void change()
    {
        //int tmp = 0;


        tmp = weapon_dummy.use_weapon;
        if (tmp < 8)
        {
            weapon_dummy.use_weapon += 1;
        }


    }
}
