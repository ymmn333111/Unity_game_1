using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// �Q�[���I�����ɃV�[���J�ڏ���������X�N���v�g
public class result_value_send : MonoBehaviour
{

    public GameObject gameobject;
    public GameObject Score;
    // enemy�̎��
    public GameObject Enemy;
    // enemy�̎��ʏ����ɕK�v
    enemy_status enemyStatus;
    // �Q�[���̏��s���菈���ɕK�v
    GameResult_judge script_judge;
    // �X�R�A�����ɕK�v
    score_board scipt_score;
    private void Start()
    {
        script_judge = gameobject.GetComponent<GameResult_judge>();
        scipt_score = Score.GetComponent<score_board>();
        enemyStatus = Enemy.GetComponent<enemy_status>();

        // result�V�[���ւ̑J�ڏ���
        SceneManager.sceneLoaded += GameSceneScoreLoaded;
        SceneManager.LoadScene("result");
    }

    // result�V�[���ւ̑J�ڏ���
    private void GameSceneScoreLoaded(Scene next, LoadSceneMode mode)
    {
        // ���s�E�X�R�A�Eenemy�̎�ނɂ��Ă̏����i�[����ϐ�
        var gameManager = GameObject.FindWithTag("GameManager").GetComponent<battle_judge>();
        var gameManager1 = GameObject.FindWithTag("GameManager").GetComponent<result_score>();
        var gameManager2 = GameObject.FindWithTag("GameManager").GetComponent<high_score>();
        var gameManager3 = GameObject.FindWithTag("GameManager").GetComponent<result_enemy_num>();

        // ���s���
        gameManager.game_result = script_judge.judgement;
        // �X�R�A���
        gameManager1.score = scipt_score.score;
        // �X�e�[�W�̃n�C�X�R�A���
        gameManager2.score = scipt_score.score;
        // enemy�̎�ޏ��
        gameManager3.enemy_num = enemyStatus.enemy_number;
        Debug.Log("{gameManager3.enemy_num}");

        SceneManager.sceneLoaded -= GameSceneScoreLoaded;

    }
}
