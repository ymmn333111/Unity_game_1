using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_left : MonoBehaviour
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
        print("left");
        change();
        Debug.Log(tmp);
    }
    public void change()
    {
        audioSource.PlayOneShot(sound1);
        //weaponƒƒjƒ…[‚É•\Ž¦‚³‚ê‚Ä‚¢‚é”Žš‚ð‚PŒ¸‚ç‚·
        tmp = script.use_weapon;
        if (tmp >= script.min_weapon_number)
        {
            script.use_weapon -= 1;
        }


    }
}
