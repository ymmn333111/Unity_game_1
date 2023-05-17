using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �G�̒e�̃_���[�W�𒲐����鏈��
public class enemy_bullet_damage : MonoBehaviour
{
    // �_���[�W��
    public int damage = 10;
    // �e���ˏo����Ă��������܂ł̎���
    public float destroy_time = 5f;
    void Update()
    {
        Destroy(this.gameObject, destroy_time);
    }
    // �G�̒e�Ƃ̐ڐG����
    private void OnTriggerEnter2D(Collider2D other)
    {
        // player�ɒe���ڐG�����ꍇ�̏���
        if (other.gameObject.CompareTag("Player"))
        {

            var damagetarget = other.gameObject.GetComponent<IDamagable>();


            if (damagetarget != null)
            {
                other.gameObject.GetComponent<IDamagable>().AddDamage(damage);
                other.gameObject.GetComponent<IDamagable>().AddEnergy(damage);
                other.gameObject.GetComponent<IDamagable>().AddScore(damage);
            }
            Destroy(this.gameObject);
        }
    }
}
