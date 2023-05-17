using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��莞�Ԍ�Ɋg�U���鐯�`�̍U��������X�N���v�g
public class enemy_bullet_bom : MonoBehaviour
{
    // �G�̎��
    public GameObject Enemy;
    // �G�̒e���ˏo�����ꏊ
    public GameObject muzzle;
    // �e�̑��x
    public float bullet_speed = 10f;
    enemy_status enemy_hp;
    private float time = 0f;
    // �e�̊Ԋu
    public float bullet_timer = 0.5f;
    // �G�̒e�̎��
    public GameObject bom;
    // �G��HP�̍ő��
    private int max_hp;
    void Start()
    {
        enemy_hp = Enemy.GetComponent<enemy_status>();
        max_hp = enemy_hp.hp;
    }

    void Update()
    {
        if (enemy_hp.hp <= 0)
        {
            this.enabled = false;
        }

        // �G��HP���ő�ʂ̔����ɂȂ����Ƃ��ɒe�̊Ԋu�𑁂߂鏈��
        if (enemy_hp.hp <= max_hp/2)
        {
            bullet_timer = 0.4f;
        }
        time += Time.deltaTime;

        if (time >= bullet_timer)
        {
            time = 0f;
            GameObject new_bom = Instantiate(bom, muzzle.transform.position, transform.rotation);
            new_bom.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * -1f);

        }

    }
}
