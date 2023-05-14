 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_status : MonoBehaviour, IDamagable
{
    public int hp = 500;
    public int energy = 0;
    public int max_energy = 100;
    public int max_hp = 500;
    private float time = 0f;
    public float limit_time = 3f;
    public GameObject player_score;
    score_board script;
    public GameObject chaege_effect;
    public bool charged = false;
    public AudioClip sound1;
    AudioSource audioSource;
    void Start()
    {
        script = player_score.GetComponent<score_board>();
        audioSource = GetComponent<AudioSource>();
    }
    public void AddEnergy(int damage)
    {
        if (energy + damage >= max_energy)
        {
            charged = true;
            energy = max_energy;
        }
        else
        {
            charged = false;

            if (hp <= max_hp / 3 * 2)
            {
                energy += damage * 4;
            }
            else if (hp <= max_hp / 3)
            {
                energy += damage * 8;
            }
            else
            {
                energy += damage;
            }
            
        }
        


    }
    public void AddDamage(int damage)
    {
        hp -= damage;

     
        if (hp <= 0)
        {
            
            
            var renderer = gameObject.GetComponent<Renderer>();

            renderer.enabled = false;
            chaege_effect.SetActive(false);
            this.GetComponent<Move_key>().enabled = false;
        }
    }

    public void AddScore(int damage)
    {
        script.score += damage;
    }

    void Update()
    {
        if (hp <= 0)
        {
            if (time >= limit_time / 3 && time <= limit_time / 3 + Time.deltaTime)
            {
                Debug.Log("sssss");
                audioSource.PlayOneShot(sound1);
            }
            if (time >= limit_time / 3 * 2 && time <= limit_time / 3 * 2 + Time.deltaTime)
            {
                Debug.Log("sssss");
                audioSource.PlayOneShot(sound1);
            }
            if (time == 0)
            {
                Debug.Log("sssss");
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
