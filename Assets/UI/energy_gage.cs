using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energy_gage : MonoBehaviour
{
    public Slider slider;
    public GameObject Player;
    player_status script;
    void Start()
    {
        Player = GameObject.Find("Player"); //Player���I�u�W�F�N�g�̖��O����擾���ĕϐ��Ɋi�[����
        script = Player.GetComponent<player_status>();
        slider.value = script.energy;
    }
    void Update()
    {
        slider.value = script.energy;

    }

}
