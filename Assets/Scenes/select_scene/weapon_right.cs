using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_right : MonoBehaviour
{
    private int tmp = 0;
    public GameObject Weapon;
    weapon_data script;
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        script = Weapon.GetComponent<weapon_data>();
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void OnClick()
    { 
        change();
    }
    public void change()
    {
        audioSource.PlayOneShot(sound1);
        //weaponƒƒjƒ…[‚É•\¦‚³‚ê‚Ä‚¢‚é”š‚ğ‚P‘‚â‚·
        tmp = script.use_weapon;
        if (tmp < script.max_weapon_number)
        {
            script.use_weapon += 1;
        }


    }
}
