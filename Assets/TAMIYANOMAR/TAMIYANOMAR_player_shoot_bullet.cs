using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class TAMIYANOMAR_player_shoot_bullet : MonoBehaviour
    {
        public GameObject player_bullet;
        public GameObject player_muzle;
        private float bullet_speed = 20f;

        static private float timer_max = 0.3f;
        private float timer = timer_max;
        void Update()
        {
            timer -= Time.deltaTime;
            if (Input.GetKey(KeyCode.Z))
            {
                if (timer < 0)
                {
                    timer = timer_max;
                    GameObject new_bullet = Instantiate(player_bullet, player_muzle.transform.position, transform.rotation);
                    GameObject new_bullet1 = Instantiate(player_bullet, player_muzle.transform.position, transform.rotation);
                    GameObject new_bullet2 = Instantiate(player_bullet, player_muzle.transform.position, transform.rotation);
                    new_bullet1.transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + 15);
                    new_bullet2.transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z - 15);
                    new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * 1f);
                    new_bullet1.GetComponent<Rigidbody2D>().velocity = new Vector2(-1 * bullet_speed * 1f * 0.258819045f, bullet_speed * 1f * 0.965925826f);
                    new_bullet2.GetComponent<Rigidbody2D>().velocity = new Vector2( bullet_speed * 1f * 0.258819045f,  bullet_speed * 1f * 0.965925826f);

                }

            }
        }
    }
}
