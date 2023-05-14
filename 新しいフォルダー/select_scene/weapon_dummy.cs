using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_dummy : MonoBehaviour
{
    public static int use_weapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (use_weapon < 0)
        {
            use_weapon = 0;
        }
        else if (use_weapon >= 8)
        {
            use_weapon = 8;
        }
    }
    public int GetSetProperty
    {
        get { return use_weapon; }
        set { use_weapon = value; }
    }
}
