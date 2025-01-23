using System;
using UnityEngine;
using UnityEngine.UI;

public class ShowTime : MonoBehaviour
{
    public Text timeText; // ลิงก์กับ Text UI ใน Inspector

    void Start()
    {
        // ดึงเวลาที่บันทึกไว้จาก PlayerPrefs
        string finalTime = PlayerPrefs.GetString("FinalTime", "00:00:00"); // ค่าเริ่มต้นคือ "00:00:00" หากไม่มีข้อมูล

        // แสดงผลเวลาใน UI
        timeText.text = "Time Played: " + FormatTime(finalTime);

        // ลบข้อมูลที่บันทึกไว้หลังแสดงผล
        PlayerPrefs.DeleteKey("FinalTime");
    }

    // ฟังก์ชันสำหรับการแปลงเวลาให้เป็นรูปแบบชั่วโมง:นาที:วินาที
    string FormatTime(string timeString)
    {
        // แปลงจาก TimeSpan string เป็น TimeSpan object
        TimeSpan time = TimeSpan.Parse(timeString);

        // คำนวณชั่วโมง, นาที และ วินาที
        int hours = time.Hours;
        int minutes = time.Minutes;
        int seconds = time.Seconds;

        // คืนค่าในรูปแบบที่ไม่แสดงเศษวินาที
        return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
    }
}
