using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class result_enemy_num : MonoBehaviour
{
    public int enemy_num;
    public TMP_Text enemy_numText;

    void Start()
    {
        enemy_numText.text = enemy_num.ToString();
    }
}
