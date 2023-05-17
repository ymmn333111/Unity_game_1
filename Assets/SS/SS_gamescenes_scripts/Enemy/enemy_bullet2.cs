using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// •¡”‚Ì’e‚ğîó‚É•úo‚·‚é“G‚ÌUŒ‚‚ÌƒXƒNƒŠƒvƒg
public class enemy_bullet2 : MonoBehaviour
{
    // “G‚Ìí—Ş
    public GameObject Enemy;
    // ’e‚Ìí—Ş
    public GameObject bullet3;
    // ’e‚ªo‚éêŠ
    public GameObject muzzle;
    // ’e‚Ì‘¬“x
    public float bullet_speed = 10f;
    enemy_status enemy_hp;
    private float time = 0f;
    // ’e‚ÌŠÔŠu
    public float bullet_timer = 0.5f;

    // ’e‚ÌŠp“x‚ğ•ÏX‚·‚é•Ï”
    private float angle;
    public float angle_change = -90f;
    // Å¬Šp“x
    public float min_angle = -70f;
    // Å‘åŠp“x
    public float max_angle = 70f;
    // “¯‚ÉËo‚³‚ê‚é’e‚Ì—Ê
    public int count = 3;

    // Šp“x‚ğ•ÏX‚·‚éˆ—
    public static Vector2 AngleToVector2(float angle)
    {
        var radian = angle * (Mathf.PI / 180);
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian)).normalized;
    }
    void Start()
    {
        enemy_hp = Enemy.GetComponent<enemy_status>();
    }

    void Update()
    {
        if (enemy_hp.hp <= 0)
        {
            this.enabled = false;
        }
        time += Time.deltaTime;

        if (time >= bullet_timer)
        {
            time = 0f;
            // ’e‚Ì•úoŠp“x‚ğ•ÏX‚µ‚È‚ª‚çcount‚Ì”•ªUŒ‚‚·‚éˆ—
            for (int i = 0; i < count; i++)
            {
                float angle = Random.Range(min_angle, max_angle);
                GameObject new_bullet = Instantiate(bullet3, muzzle.transform.position, transform.rotation);
                var a = AngleToVector2(angle);
                var angles = new_bullet.transform.localEulerAngles;
                angles.z = angle + angle_change;
                new_bullet.transform.localEulerAngles = angles;
                new_bullet.GetComponent<Rigidbody2D>().velocity = a * bullet_speed;
            }
            
        }

    }
}
