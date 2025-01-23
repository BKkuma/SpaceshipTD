using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // สำหรับการใช้งาน UI

public class Timer : MonoBehaviour
{
    public Text timerText; // ตัวแปรสำหรับเชื่อมต่อกับ Text UI
    private float timePlayed = 0f; // ตัวแปรเก็บเวลาที่เล่นไป

    void Update()
    {
        // เพิ่มเวลาทุกครั้งที่ Update
        timePlayed += Time.deltaTime;

        // อัปเดต UI ให้แสดงเวลา
        UpdateTimeText();
    }

    // ฟังก์ชันอัปเดตการแสดงผลเวลา
    void UpdateTimeText()
    {
        // แปลงเวลาเป็นนาทีและวินาที
        int minutes = Mathf.FloorToInt(timePlayed / 60f); // นาที
        int seconds = Mathf.FloorToInt(timePlayed % 60f); // วินาที

        // แสดงผลเวลาในรูปแบบ "นาที:วินาที"
        timerText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }
}
