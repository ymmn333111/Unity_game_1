using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_status : MonoBehaviour, EDmage
{
    public int hp = 500;
    public GameObject player_score;
    public GameObject gameobject;
    private float time = 0f;
    public float limit_time = 3f;
    GameResult_judge judge_script;
    score_board script;
    public AudioClip sound1;
    AudioSource audioSource;
    public int enemy_number=1;
    void Start()
    {
        script = player_score.GetComponent<score_board>();
        judge_script = gameobject.GetComponent<GameResult_judge>();
        audioSource = GetComponent<AudioSource>();
    }
    public void AddDamage(int damage)
    {
        hp -= damage;


        if (hp <= 0)
        {
            judge_script.judgement = true;

        }
    }
    public void AddScore(int damage)
    {
        script.score += damage * 10;
    }

    void Update()
    {
        if (hp <= 0)
        {
            if (time >= limit_time / 3 && time <= limit_time / 3 + Time.deltaTime)
            {
                audioSource.PlayOneShot(sound1);
            }
            if (time >= limit_time / 3 * 2 && time <= limit_time / 3 * 2+ Time.deltaTime)
            {
                audioSource.PlayOneShot(sound1);
            }
            if (time == 0)
            {
                audioSource.PlayOneShot(sound1);
            }
            
            if (time >= limit_time)
            {
                this.gameObject.SetActive(false);
                GetComponent<result_value_send>().enabled = true;
            }
            time += Time.deltaTime;
        }

    }
}