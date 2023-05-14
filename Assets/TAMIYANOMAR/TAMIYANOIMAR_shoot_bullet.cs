using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class TAMIYANOMAR_shoot_bullet : MonoBehaviour
    {
        public GameObject bullet;
        public GameObject muzzle;
        private float time = -1f;
        public float bullet_speed = 10f;

        void Update()
        {
            time += Time.deltaTime;


            if (time >= 0.5f)
            {
                time = 0f;
                GameObject new_bullet = Instantiate(bullet, muzzle.transform.position, transform.rotation);
                if (bullet.name != "look_at_player_bullet") new_bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bullet_speed * -1f);
            }
        }


    }
}
