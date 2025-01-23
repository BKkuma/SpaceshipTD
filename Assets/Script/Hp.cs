using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // เพิ่มการใช้งาน UI
using UnityEngine.SceneManagement; // สำหรับการโหลดฉาก

public class Hp : MonoBehaviour
{
    public int hp = 10; // กำหนดค่า HP เริ่มต้น
    public Text hpText; // ตัวแปรเพื่อเก็บอ้างอิงไปยัง Text UI

    // เรียกใช้งานเมื่อเกิดการชนในเกม 2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ตรวจสอบว่า GameObject ที่ชนมีแท็ก "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            hp -= 1; // ลด HP ลง 1
            Debug.Log("HP ลดลง: " + hp);

            // อัปเดตการแสดงผล HP
            UpdateHPText();

            // หาก HP น้อยกว่าหรือเท่ากับ 0
            if (hp <= 0)
            {
                Debug.Log("Game Over!");
                LoadGameWinScene(); // โหลดฉาก GameWin
            }
        }
    }

    void LoadGameWinScene()
    {
        SceneManager.LoadScene("GameWin"); // โหลดฉากที่ชื่อว่า "GameWin"
    }

    // ฟังก์ชันเพื่ออัปเดตค่า HP ใน UI
    void UpdateHPText()
    {
        if (hpText != null)
        {
            hpText.text = "HP: " + hp.ToString(); // แสดงค่า HP ใน Text UI
        }
    }
}
