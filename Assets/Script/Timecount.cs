using System;
using UnityEngine;
using UnityEngine.UI; // สำหรับการใช้งาน UI

public class RealTimeTimer : MonoBehaviour
{
    public Text timerText; // เชื่อมต่อกับ Text UI ที่จะแสดงเวลา
    private DateTime startTime; // เก็บเวลาที่เริ่มเกม

    void Start()
    {
        // บันทึกเวลาปัจจุบันเมื่อเริ่มเกม
        startTime = DateTime.Now;
    }

    void Update()
    {
        // คำนวณเวลาที่ผ่านมา
        TimeSpan elapsedTime = DateTime.Now - startTime;

        // อัปเดต UI ให้แสดงเวลา
        UpdateTimeText(elapsedTime);
    }

    // ฟังก์ชันอัปเดตการแสดงผลเวลา
    void UpdateTimeText(TimeSpan elapsedTime)
    {
        // แปลงเวลาเป็นชั่วโมง:นาที:วินาที
        timerText.text = string.Format("Time: {0:D2}:{1:D2}:{2:D2}",
            elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds);
    }
}
