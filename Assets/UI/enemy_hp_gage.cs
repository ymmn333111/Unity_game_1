using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_hp_gage : MonoBehaviour
{
    public Slider slider;
    public GameObject Enemy;
    enemy_status script;
    void Start()
    {
        script = Enemy.GetComponent<enemy_status>();
        slider.value = script.hp;
    }
    void Update()
    {
        slider.value = script.hp;

    }
}
