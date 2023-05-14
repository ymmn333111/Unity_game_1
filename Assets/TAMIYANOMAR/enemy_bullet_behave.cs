using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class enemy_bullet_behave : MonoBehaviour
    {
        private GameObject player_obj;
        public string player_name = "Player";
        private float gap_x;
        void Start()
        {
            player_obj = GameObject.Find(player_name);
        }

        void Update()
        {
            gap_x = player_obj.transform.position.x - this.transform.position.x;

            this.transform.position = new Vector2(this.transform.position.x + (gap_x * Time.deltaTime), this.transform.position.y);
        }
    }
}
