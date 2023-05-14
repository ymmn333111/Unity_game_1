using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charge_effect : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector2 player_pos;
    private GameObject player_obj;
    public GameObject effect_pos;


    void Start()
    {
        player_obj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        player_pos = player_obj.transform.position;
        effect_pos.transform.position = player_pos;
    }
}
