using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// enemyのステータスを設定するスクリプト
public class enemy_status : MonoBehaviour, EDmage
{
    // 敵のHP 
    public int hp = 500;
    // playerのスコア情報
    public GameObject player_score;
    public GameObject gameobject;

    private float time = 0f;
    public float limit_time = 3f;

    // 勝敗判定をするスクリプトを取得
    GameResult_judge judge_script;
    score_board script;

    // 音源
    public AudioClip sound1;
    AudioSource audioSource;

    // 敵の識別番号
    public int enemy_number=1;
    void Start()
    {
        script = player_score.GetComponent<score_board>();
        judge_script = gameobject.GetComponent<GameResult_judge>();
        audioSource = GetComponent<AudioSource>();
    }

    // playerから受けるダメージの計算
    public void AddDamage(int damage)
    {
        hp -= damage;


        if (hp <= 0)
        {
            judge_script.judgement = true;

        }
    }

    // ダメージを与えた際のスコア加算
    public void AddScore(int damage)
    {
        script.score += damage * 10;
    }

    void Update()
    {
        // 敵のHPが０になった時のSE音の処理
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