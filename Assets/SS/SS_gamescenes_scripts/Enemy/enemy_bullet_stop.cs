using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �O�p�̒e���ˏo���ꂽ���莞�ԃt�B�[���h�ɂƂǂ܂�悤�ɐݒ肷��X�N���v�g
public class enemy_bullet_stop : MonoBehaviour
{
    // �e���~�܂�܂ł̌o�ߎ��Ԃ��v��
    private float time_manage = 0f;
    // ��~���鎞�Ԃ��i�[����ϐ�
    public float time_stop;
    // ��~���鎞�Ԃ̕�
    public float min_time = 0.1f;
    public float max_time = 1f;

    void Start()
    {
        time_stop = Random.Range(min_time, max_time);
    }


    void Update()
    {
        // �e����~���鏈��
        if (time_manage >= time_stop)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Destroy(this.gameObject, 5);
        }
        time_manage += Time.deltaTime;
    }
}
