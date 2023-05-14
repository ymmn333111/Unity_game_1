using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class result_value_send : MonoBehaviour
{
    public GameObject gameobject;
    public GameObject Score;
    public GameObject Enemy;
    enemy_status enemyStatus;
    GameResult_judge script_judge;
    score_board scipt_score;
    private void Start()
    {
        script_judge = gameobject.GetComponent<GameResult_judge>();
        scipt_score = Score.GetComponent<score_board>();
        enemyStatus = Enemy.GetComponent<enemy_status>();

        SceneManager.sceneLoaded += GameSceneScoreLoaded;
        SceneManager.LoadScene("result");
    }
    private void GameSceneScoreLoaded(Scene next, LoadSceneMode mode)
    {

        var gameManager = GameObject.FindWithTag("GameManager").GetComponent<battle_judge>();
        var gameManager1 = GameObject.FindWithTag("GameManager").GetComponent<result_score>();
        var gameManager2 = GameObject.FindWithTag("GameManager").GetComponent<high_score>();
        var gameManager3 = GameObject.FindWithTag("GameManager").GetComponent<result_enemy_num>();

        gameManager.game_result = script_judge.judgement;
        gameManager1.score = scipt_score.score;
        gameManager2.score = scipt_score.score;
        gameManager3.enemy_num = enemyStatus.enemy_number;
        Debug.Log("{gameManager3.enemy_num}");

        SceneManager.sceneLoaded -= GameSceneScoreLoaded;

    }
}
