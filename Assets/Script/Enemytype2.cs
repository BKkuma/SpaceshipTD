using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemytype2 : MonoBehaviour
{
    public float moveSpeed = 3f; // ��������㹡������͹������-���
    public float moveRange = 5f; // ���з���ѵ�٨�����͹������-���
    private Vector3 startPosition; // ���˹�������鹢ͧ�ѵ��

    public GameObject bulletPrefab; // ����ع����ѵ���ԧ
    public Transform bulletSpawnPoint; // �ش������ع�١���ҧ���
    public float shootInterval = 3f; // ���������ҧ����ԧ���Ф���

    public GameObject vfx;
    public int scoreValue = 20;

    void Start()
    {
        startPosition = transform.position; // �ѹ�֡���˹�������鹢ͧ�ѵ��
        InvokeRepeating("ShootBullet", shootInterval, shootInterval); // �ԧ����ع�ء� 3 �Թҷ�
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Enemy"), LayerMask.NameToLayer("Enemy"));
    }

    void Update()
    {
        // ������ѵ������͹������-��Ҵ��� Mathf.PingPong()
        float moveX = Mathf.PingPong(Time.time * moveSpeed, moveRange * 2) - moveRange;
        transform.position = new Vector3(startPosition.x + moveX, transform.position.y, transform.position.z);
    }

    void ShootBullet()
    {
        if (bulletPrefab != null && bulletSpawnPoint != null)
        {
            Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            // ������ṹ
            ScoreManager.instance.AddScore(scoreValue);

            if (vfx != null)
            {
                Instantiate(vfx, transform.position, transform.rotation);
                Destroy(vfx.gameObject);
            }
            // ����� Enemy ��� Bullet
            Destroy(collision.gameObject); // ����� Bullet
            Destroy(gameObject); // ����� Enemy


        }
    }
    
}
