using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ゲーム終了時にシーン遷移処理をするスクリプト
public class result_value_send : MonoBehaviour
{

    public GameObject gameobject;
    public GameObject Score;
    // enemyの種類
    public GameObject Enemy;
    // enemyの識別処理に必要
    enemy_status enemyStatus;
    // ゲームの勝敗判定処理に必要
    GameResult_judge script_judge;
    // スコア処理に必要
    score_board scipt_score;
    private void Start()
    {
        script_judge = gameobject.GetComponent<GameResult_judge>();
        scipt_score = Score.GetComponent<score_board>();
        enemyStatus = Enemy.GetComponent<enemy_status>();

        // resultシーンへの遷移処理
        SceneManager.sceneLoaded += GameSceneScoreLoaded;
        SceneManager.LoadScene("result");
    }

    // resultシーンへの遷移処理
    private void GameSceneScoreLoaded(Scene next, LoadSceneMode mode)
    {
        // 勝敗・スコア・enemyの種類についての情報を格納する変数
        var gameManager = GameObject.FindWithTag("GameManager").GetComponent<battle_judge>();
        var gameManager1 = GameObject.FindWithTag("GameManager").GetComponent<result_score>();
        var gameManager2 = GameObject.FindWithTag("GameManager").GetComponent<high_score>();
        var gameManager3 = GameObject.FindWithTag("GameManager").GetComponent<result_enemy_num>();

        // 勝敗情報
        gameManager.game_result = script_judge.judgement;
        // スコア情報
        gameManager1.score = scipt_score.score;
        // ステージのハイスコア情報
        gameManager2.score = scipt_score.score;
        // enemyの種類情報
        gameManager3.enemy_num = enemyStatus.enemy_number;
        Debug.Log("{gameManager3.enemy_num}");

        SceneManager.sceneLoaded -= GameSceneScoreLoaded;

    }
}
