using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp : MonoBehaviour
{
    public int hp = 10; // กำหนดค่า HP เริ่มต้น

    // เรียกใช้งานเมื่อเกิดการชนในเกม 2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ตรวจสอบว่า GameObject ที่ชนมีแท็ก "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hp -= 1; // ลด HP ลง 1
            Debug.Log("HP ลดลง: " + hp);

            // หาก HP น้อยกว่าหรือเท่ากับ 0
            if (hp <= 0)
            {
                Debug.Log("Game Over!");
                // ตัวอย่าง: ทำลาย GameObject ของผู้เล่น
                Destroy(gameObject);
            }
        }
    }
}
