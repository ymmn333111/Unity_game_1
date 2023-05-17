 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_status : MonoBehaviour, IDamagable
{
    // player�̌��݂�hp
    public int hp = 500;
    // player�̌��݂̃G�l���M�[��
    public int energy = 0;
    // player���r�[����ł̂ɕK�v�ȃG�l���M�[��
    public int max_energy = 100;
    // player��hp���
    public int max_hp = 500;

    // �Q�[���I�[�o�[����SE������
    private float time = 0f;
    public float limit_time = 3f;
    
    // player���l������X�R�A
    public GameObject player_score;
    // �G�l���M�[������ɒB�����ۂ̃G�t�F�N�g
    public GameObject chaege_effect;
    // �G�l���M�[��������ۂ��𔻒肷��ϐ�
    public bool charged = false;
    // �X�R�A�v�Z
    score_board script;
    
    // SE��
    public AudioClip sound1;
    AudioSource audioSource;
    
    void Start()
    {
        // player�X�R�A�v�Z�ɕK�v�ȃX�N���v�g���l��
        script = player_score.GetComponent<score_board>();
        // �����擾
        audioSource = GetComponent<AudioSource>();
    }

    //�_���[�W���̃G�l���M�[���Z
    public void AddEnergy(int damage)
    {
        // �G�l���M�[�����^�����ǂ����𔻒�
        if (energy + damage >= max_energy)
        {
            charged = true;
            energy = max_energy;
        }
        else
        {
            charged = false;

            // ���݂̗̑͂�1/3�̊������ƂɃG�l���M�[�̑����ʂ�������
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

    //��e�_���[�W�̌v�Z
    public void AddDamage(int damage)
    {
        hp -= damage;

     
        if (hp <= 0)
        {
            
            //player�̃Q�[���I�[�o�[�A�N�V����
            var renderer = gameObject.GetComponent<Renderer>();

            renderer.enabled = false;
            chaege_effect.SetActive(false);
            this.GetComponent<Move_key>().enabled = false;
        }
    }

    //�_���[�W���̃v���C���[�X�R�A���Z
    public void AddScore(int damage)
    {
        script.score += damage;
    }

    void Update()
    {
        // �Q�[���I�[�o�[���̃G�t�F�N�g
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
