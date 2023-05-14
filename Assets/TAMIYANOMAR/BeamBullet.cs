using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TAMIYANOMAR
{
    public class BeamBullet : MonoBehaviour
    {
        private GameObject target_obj;
        private Vector2 exPosition;

        private void Start()
        {
            Destroy(this.gameObject, 3f);
        }
        void Update()
        {
            target_obj = FetchNearObjectWithTag("Enemy");
            Vector2 gap = new Vector2(this.transform.position.x , this.transform.position.y) - exPosition;
            if(!target_obj)
            {
                Destroy(this.gameObject);
                return;
            }
            Transform nearTransform = target_obj.transform;
            float gap_x = target_obj.transform.position.x - this.transform.position.x;
            this.transform.position = new Vector2(this.transform.position.x + 4 *(gap_x * Time.deltaTime), this.transform.position.y);
        }

        private GameObject FetchNearObjectWithTag(string tagName)
        {
            var targets = GameObject.FindGameObjectsWithTag(tagName);
            if (targets.Length == 1) return targets[0];
            GameObject result = null;
            var minTargetDistance = float.MaxValue;
            foreach (var target in targets)
            {
                var targetDistance = Vector2.Distance(transform.position, target.transform.position);
                if (!(targetDistance < minTargetDistance)) continue;
                minTargetDistance = targetDistance;
                result = target.transform.gameObject;
            }
            return result;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(this.gameObject);
        }
    }
}
