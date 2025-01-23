using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text scoreText; // ลิงก์กับ Text UI ใน Inspector

    void Start()
    {
        // ดึงคะแนนจาก ScoreManager และแสดงผล
        int finalScore = ScoreManager.instance.score; // ดึงคะแนนจาก ScoreManager
        scoreText.text = "Your Score: " + finalScore;
    }
}
