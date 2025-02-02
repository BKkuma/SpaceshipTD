using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D rg2dEnemy;
    public float enemySP = 5f;
    public int scoreValue = 10;
    public GameObject vfx;
    // Start is called before the first frame update
    void Start()
    {
        rg2dEnemy = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Enemy"), LayerMask.NameToLayer("Enemy"));
    }

    // Update is called once per frame
    void Update()
    {
        rg2dEnemy.velocity = Vector2.down * enemySP;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Bullet")) // ���������ѵ�ٶ١��Ҵ��� Bullet
        {
            // ������ṹ
            ScoreManager.instance.AddScore(scoreValue);

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
