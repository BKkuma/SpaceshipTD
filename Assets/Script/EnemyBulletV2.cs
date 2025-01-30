using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletV2 : MonoBehaviour
{
    public float speed = 2f; // �������Ǣͧ����ع
    public GameObject vfx;

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime; // ����ع����͹���ŧ
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
           if (collision.collider.CompareTag("Wall"))
        {
            Destroy(gameObject); // ����¡���ع����ͪ���ᾧ
        }
        if (collision.collider.CompareTag("Bullet"))
        {
            if (vfx != null)
            {
                Instantiate(vfx, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            // ����� Enemy ��� Bullet
            Destroy(collision.gameObject); // ����� Bullet
            Destroy(gameObject); // ����� Enemy
        }
    }
}
