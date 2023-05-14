using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer_control : MonoBehaviour
{
    // Start is called before the first frame update
    public static float current_time;
    void Start()
    {
        current_time = -4f;
    }

    // Update is called once per frame
    void Update()
    {
        float delta_time;

        delta_time = Time.deltaTime;
        current_time += delta_time;

    }
    public static float Get_Timer()
    {
        return current_time;
    }
}
