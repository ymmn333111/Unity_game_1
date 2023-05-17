using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ŽOŠp‚Ì’e‚ªŽËo‚³‚ê‚½Œãˆê’èŽžŠÔƒtƒB[ƒ‹ƒh‚É‚Æ‚Ç‚Ü‚é‚æ‚¤‚ÉÝ’è‚·‚éƒXƒNƒŠƒvƒg
public class enemy_bullet_stop : MonoBehaviour
{
    // ’e‚ªŽ~‚Ü‚é‚Ü‚Å‚ÌŒo‰ßŽžŠÔ‚ðŒv‘ª
    private float time_manage = 0f;
    // ’âŽ~‚·‚éŽžŠÔ‚ðŠi”[‚·‚é•Ï”
    public float time_stop;
    // ’âŽ~‚·‚éŽžŠÔ‚Ì•
    public float min_time = 0.1f;
    public float max_time = 1f;

    void Start()
    {
        time_stop = Random.Range(min_time, max_time);
    }


    void Update()
    {
        // ’e‚ª’âŽ~‚·‚éˆ—
        if (time_manage >= time_stop)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Destroy(this.gameObject, 5);
        }
        time_manage += Time.deltaTime;
    }
}
