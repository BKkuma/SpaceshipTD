using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletV2 : MonoBehaviour
{
    public float speed = 2f; // ความเร็วของกระสุน
    public GameObject vfx;

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime; // กระสุนเคลื่อนที่ลง
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
           if (collision.collider.CompareTag("Wall"))
        {
            Destroy(gameObject); // ทำลายกระสุนเมื่อชนกำแพง
        }
        if (collision.collider.CompareTag("Bullet"))
        {
            if (vfx != null)
            {
                Instantiate(vfx, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            // ทำลาย Enemy และ Bullet
            Destroy(collision.gameObject); // ทำลาย Bullet
            Destroy(gameObject); // ทำลาย Enemy
        }
    }
}
