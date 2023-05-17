 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_status : MonoBehaviour, IDamagable
{
    // playerの現在のhp
    public int hp = 500;
    // playerの現在のエネルギー量
    public int energy = 0;
    // playerがビームを打つのに必要なエネルギー量
    public int max_energy = 100;
    // playerのhp上限
    public int max_hp = 500;

    // ゲームオーバー時のSE音操作
    private float time = 0f;
    public float limit_time = 3f;
    
    // playerが獲得するスコア
    public GameObject player_score;
    // エネルギーが上限に達した際のエフェクト
    public GameObject chaege_effect;
    // エネルギーが上限か否かを判定する変数
    public bool charged = false;
    // スコア計算
    score_board script;
    
    // SE音
    public AudioClip sound1;
    AudioSource audioSource;
    
    void Start()
    {
        // playerスコア計算に必要なスクリプトを獲得
        script = player_score.GetComponent<score_board>();
        // 音源取得
        audioSource = GetComponent<AudioSource>();
    }

    //ダメージ分のエネルギー加算
    public void AddEnergy(int damage)
    {
        // エネルギーが満タンかどうかを判定
        if (energy + damage >= max_energy)
        {
            charged = true;
            energy = max_energy;
        }
        else
        {
            charged = false;

            // 現在の体力が1/3の割合ごとにエネルギーの増加量が増える
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

    //被弾ダメージの計算
    public void AddDamage(int damage)
    {
        hp -= damage;

     
        if (hp <= 0)
        {
            
            //playerのゲームオーバーアクション
            var renderer = gameObject.GetComponent<Renderer>();

            renderer.enabled = false;
            chaege_effect.SetActive(false);
            this.GetComponent<Move_key>().enabled = false;
        }
    }

    //ダメージ分のプレイヤースコア加算
    public void AddScore(int damage)
    {
        script.score += damage;
    }

    void Update()
    {
        // ゲームオーバー時のエフェクト
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
