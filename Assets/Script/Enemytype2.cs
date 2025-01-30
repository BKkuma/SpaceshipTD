using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemytype2 : MonoBehaviour
{
    public float moveSpeed = 3f; // ความเร็วในการเคลื่อนที่ซ้าย-ขวา
    public float moveRange = 5f; // ระยะที่ศัตรูจะเคลื่อนที่ซ้าย-ขวา
    private Vector3 startPosition; // ตำแหน่งเริ่มต้นของศัตรู

    public GameObject bulletPrefab; // กระสุนที่ศัตรูยิง
    public Transform bulletSpawnPoint; // จุดที่กระสุนถูกสร้างขึ้น
    public float shootInterval = 3f; // เวลาระหว่างการยิงแต่ละครั้ง

    public GameObject vfx;
    public int scoreValue = 20;

    void Start()
    {
        startPosition = transform.position; // บันทึกตำแหน่งเริ่มต้นของศัตรู
        InvokeRepeating("ShootBullet", shootInterval, shootInterval); // ยิงกระสุนทุกๆ 3 วินาที
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Enemy"), LayerMask.NameToLayer("Enemy"));
    }

    void Update()
    {
        // ทำให้ศัตรูเคลื่อนที่ซ้าย-ขวาด้วย Mathf.PingPong()
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
            // เพิ่มคะแนน
            ScoreManager.instance.AddScore(scoreValue);

            if (vfx != null)
            {
                Instantiate(vfx, transform.position, transform.rotation);
                Destroy(vfx.gameObject);
            }
            // ทำลาย Enemy และ Bullet
            Destroy(collision.gameObject); // ทำลาย Bullet
            Destroy(gameObject); // ทำลาย Enemy


        }
    }
    
}
