using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// player�̃r�[������
public class player_beem_damage : MonoBehaviour
{
    // �r�[���̃_���[�W
    public int damage = 1000;
    void Update()
    {
        Destroy(this.gameObject, 5.0f);
    }

    // �r�[����enemy�ɒ��������ۂ̃_���[�W����
    private void OnTriggerExit2D(Collider2D other)
    {
        // enemy�݂̂ɏ��������s
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log($"GG");

            var damagetarget = other.gameObject.GetComponent<EDmage>();

            // enemy�ɑ΂���_���[�W�v�Z�ƃX�R�A���Z
            if (damagetarget != null)
            {
                other.gameObject.GetComponent<EDmage>().AddDamage(damage);
                other.gameObject.GetComponent<EDmage>().AddScore(damage);

            }
        }
    }
}
