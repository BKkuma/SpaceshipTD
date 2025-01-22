using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text scoreText; // ลิงก์กับ Text UI ใน Inspector

    void Start()
    {
        // ดึงคะแนนจาก PlayerPrefs และแสดงผล
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0); // ค่าเริ่มต้นคือ 0 หากไม่มีข้อมูล
        scoreText.text = "Your Score: " + finalScore;
    }
}
