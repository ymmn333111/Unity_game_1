using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class TAMIYANOMAR_player_hp : MonoBehaviour
    {
        private int hp = 3;
        public GameObject part1;
        public GameObject part2;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Enemy")
            {
                hp--;
            }

            if (hp <= 0)
            {
                this.gameObject.SetActive(false);
            }
            if (hp <= 2)
            {
                part1.SetActive(false);
            }
            if (hp <= 1)
            {
                part2.SetActive(false);
            }
        }
    }
}
