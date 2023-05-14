using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miss_effect : MonoBehaviour
{
    private Vector2 player_pos;
    private GameObject player_obj;
    public GameObject miss_effect_pos;
    // Start is called before the first frame update
    void Start()
    {
        player_obj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        player_pos = player_obj.transform.position;
        miss_effect_pos.transform.position = player_pos;
    }
}
