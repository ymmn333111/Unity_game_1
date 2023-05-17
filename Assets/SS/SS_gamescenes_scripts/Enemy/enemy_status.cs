using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// enemy�̃X�e�[�^�X��ݒ肷��X�N���v�g
public class enemy_status : MonoBehaviour, EDmage
{
    // �G��HP 
    public int hp = 500;
    // player�̃X�R�A���
    public GameObject player_score;
    public GameObject gameobject;

    private float time = 0f;
    public float limit_time = 3f;

    // ���s���������X�N���v�g���擾
    GameResult_judge judge_script;
    score_board script;

    // ����
    public AudioClip sound1;
    AudioSource audioSource;

    // �G�̎��ʔԍ�
    public int enemy_number=1;
    void Start()
    {
        script = player_score.GetComponent<score_board>();
        judge_script = gameobject.GetComponent<GameResult_judge>();
        audioSource = GetComponent<AudioSource>();
    }

    // player����󂯂�_���[�W�̌v�Z
    public void AddDamage(int damage)
    {
        hp -= damage;


        if (hp <= 0)
        {
            judge_script.judgement = true;

        }
    }

    // �_���[�W��^�����ۂ̃X�R�A���Z
    public void AddScore(int damage)
    {
        script.score += damage * 10;
    }

    void Update()
    {
        // �G��HP���O�ɂȂ�������SE���̏���
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