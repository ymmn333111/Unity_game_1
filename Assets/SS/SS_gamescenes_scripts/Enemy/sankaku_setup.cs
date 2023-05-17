using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �O�p�̒e���ˏo���邽�߂̏���������X�N���v�g
public class sankaku_setup : MonoBehaviour
{
    // �G�̎��
    public GameObject Enemy;
    // �G�̌��݂�HP
    enemy_status enemy_hp;
    // �G�̒e�̏��
    enemy_bullet4 enemy_b;
    enemy_bullet5 enemy_b2;
    // �G��HP�̍ő��
    private int max_hp;

    void Start()
    {
        enemy_hp = Enemy.GetComponent<enemy_status>();
        enemy_b = Enemy.GetComponent<enemy_bullet4>();
        enemy_b2 = Enemy.GetComponent<enemy_bullet5>();
        max_hp = enemy_hp.hp;
    }


    void Update()
    {
        // �G��HP���ő�ʂ̔����ɂȂ����ۂɎO�p�̒e�����o�����悤�ɂ��鏈��
        if (enemy_hp.hp <= max_hp / 2)
        {
            enemy_b.enabled = true;
            enemy_b2.enabled = true;
        }
    }
}
